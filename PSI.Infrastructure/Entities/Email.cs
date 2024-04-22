namespace PSI.Domain.Entities;

public partial class Email : BaseEntity<int>
{
	public string Description { get; set; } = null!;

	public string EmailName { get; set; } = null!;

	public int CustomerId { get; set; }

	public virtual Customer Customer { get; set; } = null!;
}
