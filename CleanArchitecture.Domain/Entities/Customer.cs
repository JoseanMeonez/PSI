namespace Domain.Entities;

public partial class Customer : BaseEntity<int>
{
	public required string Name { get; set; }

	public required string LastName { get; set; }

	public string? MarriedLastName { get; set; }

	public required string Address { get; set; }

	public int GenderId { get; set; }

	public int NationalityId { get; set; }

	public int IdentificationTypeId { get; set; }

	public required string IdentificationValue { get; set; }

	public int NeighborhoodId { get; set; }

	public int? ProspectId { get; set; }

	public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

	public virtual Gender? Gender { get; set; }

	public virtual IdentificationType? IdentificationType { get; set; }

	public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

	public virtual Prospect? Prospect { get; set; }

	public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
}
