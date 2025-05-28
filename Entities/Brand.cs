namespace Entities;

public class Brand
{
    public string Name { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}