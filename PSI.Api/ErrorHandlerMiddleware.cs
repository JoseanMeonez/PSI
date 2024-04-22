using Microsoft.EntityFrameworkCore;
using PSI.Application.Exceptions;
using PSI.Application.Wrappers;
using System.Text.Json;

namespace PSI.Api;

public class ErrorHandlerMiddleware
{
	private readonly RequestDelegate _next;

	public ErrorHandlerMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task Invoke(HttpContext context)
	{
		try
		{
			await _next(context);
		}
		catch (Exception error)
		{
			var response = context.Response;
			response.ContentType = "application/json";
			var responseModel = new Response<string>()
			{
				Succeeded = false,
				Message = error.Message,
			};

			switch (error)
			{
				// Custom application api error
				case ApiException e:
					response.StatusCode = StatusCodes.Status400BadRequest;
					break;

				// Custom application error
				case ValidationException e:
					response.StatusCode = StatusCodes.Status400BadRequest;
					responseModel.Errors = e.Errors;
					break;

				// Unathorized exception
				case InvalidOperationException:
					response.StatusCode = StatusCodes.Status401Unauthorized;
					break;

				// Forbidden exception
				case HttpRequestException e:
					response.StatusCode = StatusCodes.Status403Forbidden;
					break;

				// Not found error
				case KeyNotFoundException:
					response.StatusCode = StatusCodes.Status404NotFound;
					break;

				// Database error
				case DbUpdateException:
					responseModel.Message = "Ha ocurrido un error con la base de datos.";
					response.StatusCode = StatusCodes.Status500InternalServerError;
					break;

				// Unhandled error
				default:
					responseModel.Message = "Ha ocurrido un error al realizar esta acción.";
					response.StatusCode = StatusCodes.Status500InternalServerError;
					break;
			}

			var result = JsonSerializer.Serialize(responseModel);

			await response.WriteAsync(result);
		}
	}
}
