﻿using Application.Features.CustomerFeature.Dtos;
using Application.Wrappers;
using MediatR;

namespace Application.Features.CustomerFeature.Queries.GetAll;

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