using System.ComponentModel.DataAnnotations.Schema;

namespace Journal.Entities.Models;

[Table("categories", Schema = "common")]
public class Category : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
