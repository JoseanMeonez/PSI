namespace PSI.Application.Features.Customer.Dtos;

public class CustomerDto
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public string? MarriedLastName { get; set; }

	public string Address { get; set; } = null!;

	public int GenderId { get; set; }

	public string GenderName { get; set; } = null!;

	public int NationalityId { get; set; }

	public int IdentificationTypeId { get; set; }

	public string IdentificationTypeName { get; set; } = null!;

	public string IdentificationValue { get; set; } = null!;

	public int NeighborhoodId { get; set; }

	public int? ProspectId { get; set; }
}
