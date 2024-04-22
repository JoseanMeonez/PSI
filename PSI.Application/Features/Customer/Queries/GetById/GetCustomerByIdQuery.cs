using MapsterMapper;
using MediatR;
using PSI.Application.Features.Customer.Dtos;
using PSI.Application.Wrappers;
using PSI.Infrastructure.Interfaces;

namespace PSI.Application.Features.Customer.Queries.GetById;

public record GetCustomerByIdQuery(int Id) : IRequest<Response<CustomerDto>>;

public class GetCustomerByIdHandler : IRequestHandler<
	GetCustomerByIdQuery,
	Response<CustomerDto>>
{
	private readonly ICustomerRepository _customerRepository;
	private readonly IMapper _mapper;

	public GetCustomerByIdHandler(ICustomerRepository customerRepository, IMapper mapper)
	{
		_customerRepository = customerRepository;
		_mapper = mapper;
	}

	public async Task<Response<CustomerDto>> Handle(
		GetCustomerByIdQuery request,
		CancellationToken cancellationToken)
	{
		var customer = await _customerRepository.GetByIdWithIncludes(request.Id) ??
			throw new KeyNotFoundException($"No se encontró el id {request.Id}");

		var response = _mapper.Map<CustomerDto>(customer);
		return new Response<CustomerDto>(response, "Cliente encontrado.");
	}
}
