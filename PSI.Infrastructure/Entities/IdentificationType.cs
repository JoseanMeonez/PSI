namespace PSI.Domain.Entities;

public partial class IdentificationType : BaseEntity<int>
{
	public string Name { get; set; } = null!;

	public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
