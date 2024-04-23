namespace PSI.Domain.Entities;

public partial class User : BaseEntity<Guid>
{
	public string Name { get; set; } = null!;

	public string LastName { get; set; } = null!;

	public string UserName { get; set; } = null!;

	public int GenderId { get; set; }

	public byte[] PasswordHash { get; set; } = null!;

	public byte[] PasswordSalt { get; set; } = null!;

	public byte[] MasterPasswordHash { get; set; } = null!;

	public byte[] MasterPasswordSalt { get; set; } = null!;

	public bool IsActive { get; set; }

	public DateTime CreationDate { get; set; }

	public string CreatedBy { get; set; } = null!;

	public DateTime? ModificationDate { get; set; }

	public string ModificatedBy { get; set; } = null!;

	public virtual Gender Gender { get; set; } = null!;
}
