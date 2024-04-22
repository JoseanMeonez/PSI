using MediatR;
using PSI.Application.Features.Customer.Dtos;
using PSI.Application.Wrappers;

namespace PSI.Application.Features.Customer.Queries.GetById;

public record GetAllCustomersQuery() : IRequest<Response<CustomerDto>>;

public class GetAllCustomersQueryHandler : IRequestHandler<
	GetAllCustomersQuery,
	Response<CustomerDto>>
{
	public async Task<Response<CustomerDto>> Handle(
		GetAllCustomersQuery request,
		CancellationToken cancellationToken)
	{
		throw new KeyNotFoundException($"No se encontraron registros.");
	}
}
