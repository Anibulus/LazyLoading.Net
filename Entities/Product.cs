using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Product
{
    public string quantity { get; set; }
    public string name { get; set; }
    public Guid BrandId { get; set; }
    [ForeignKey(nameof(BrandId))]
    public virtual Brand Brand { get; set; }
}