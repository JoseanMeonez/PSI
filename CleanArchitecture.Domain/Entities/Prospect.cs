namespace Domain.Entities;

public partial class Prospect : BaseEntity<int>
{
	public required string Name { get; set; }

	public required string LastName { get; set; }

	public string? MarriedLastName { get; set; }

	public required string Address { get; set; }

	public int GenderId { get; set; }

	public int NationalityId { get; set; }

	public int IdentificationTypeId { get; set; }

	public required string IdentificationValue { get; set; }

	public required string PhoneNumber { get; set; }

	public required string PhoneNumberDesc { get; set; }

	public required string Email { get; set; }

	public required string EmailDesc { get; set; }

	public int NeighborhoodId { get; set; }

	public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
