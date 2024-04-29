using FluentValidation;

namespace Application.Features.CustomerFeature.Queries.GetById;

public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
{
	public GetCustomerByIdQueryValidator()
	{
		RuleFor(c => c.Id)
			.GreaterThan(0).WithMessage("{PropertyName} es inválido.")
			.WithName("El ID del cliente");
	}
}
