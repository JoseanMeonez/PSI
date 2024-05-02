using Application.Features.CustomerFeature.Common;
using Application.Wrappers;
using MediatR;

namespace Application.Features.CustomerFeature.Queries.GetAll;

public record GetAllCustomersQuery() : IRequest<Response<BasicCustomerResponse>>;

internal class GetAllCustomersQueryHandler : IRequestHandler<
	GetAllCustomersQuery,
	Response<BasicCustomerResponse>>
{
	public async Task<Response<BasicCustomerResponse>> Handle(
		GetAllCustomersQuery request,
		CancellationToken cancellationToken)
	{
		throw new KeyNotFoundException($"No se encontraron registros.");
	}
}
