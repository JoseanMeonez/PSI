namespace Domain.Entities;

public partial class Prospect : BaseEntity<int>
{
	public string Name { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public string? MarriedLastName { get; set; }

	public string Address { get; set; } = null!;

	public int GenderId { get; set; }

	public int NationalityId { get; set; }

	public int IdentificationTypeId { get; set; }

	public string IdentificationValue { get; set; } = null!;

	public string PhoneNumber { get; set; } = null!;

	public string PhoneNumberDesc { get; set; } = null!;

	public string Email { get; set; } = null!;

	public string EmailDesc { get; set; } = null!;

	public int NeighborhoodId { get; set; }

	public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
