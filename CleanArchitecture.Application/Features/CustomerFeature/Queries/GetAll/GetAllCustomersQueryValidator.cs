using FluentValidation;

namespace Application.Features.CustomerFeature.Queries.GetAll;

public class GetAllCustomersQueryValidator : AbstractValidator<GetAllCustomersQuery>
{
	public GetAllCustomersQueryValidator()
	{

	}
}
