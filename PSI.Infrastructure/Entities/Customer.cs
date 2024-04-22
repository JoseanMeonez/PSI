namespace PSI.Domain.Entities;

public partial class Customer : BaseEntity<int>
{
	public string Name { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public string? MarriedLastName { get; set; }

	public string Address { get; set; } = null!;

	public int GenderId { get; set; }

	public int NationalityId { get; set; }

	public int IdentificationTypeId { get; set; }

	public string IdentificationValue { get; set; } = null!;

	public int NeighborhoodId { get; set; }

	public int? ProspectId { get; set; }

	public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

	public virtual Gender Gender { get; set; } = null!;

	public virtual IdentificationType IdentificationType { get; set; } = null!;

	public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

	public virtual Prospect? Prospect { get; set; }

	public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
}
