using Application.Features.CustomerFeature.Responses;
using Application.Wrappers;
using Infrastructure.Interfaces;
using MapsterMapper;
using MediatR;

namespace Application.Features.CustomerFeature.Queries.GetById;

public record GetCustomerByIdQuery(int Id) : IRequest<Response<BasicCustomerResponse>>;

internal class GetCustomerByIdHandler : IRequestHandler<
	GetCustomerByIdQuery,
	Response<BasicCustomerResponse>>
{
	private readonly ICustomerRepository _customerRepository;
	private readonly IMapper _mapper;

	public GetCustomerByIdHandler(ICustomerRepository customerRepository, IMapper mapper)
	{
		_customerRepository = customerRepository;
		_mapper = mapper;
	}

	public async Task<Response<BasicCustomerResponse>> Handle(
		GetCustomerByIdQuery request,
		CancellationToken cancellationToken)
	{
		var customer = await _customerRepository.GetByIdWithIncludes(request.Id) ??
			throw new KeyNotFoundException($"No se encontró el id {request.Id}");

		var response = _mapper.Map<BasicCustomerResponse>(customer);
		return new Response<BasicCustomerResponse>(response, "Cliente encontrado.");
	}
}
