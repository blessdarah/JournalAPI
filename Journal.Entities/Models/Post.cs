using System.ComponentModel.DataAnnotations.Schema;

namespace Journal.Entities.Models;

[Table("posts", Schema = "common")]
public class Post : BaseEntity
{
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Body { get; set; }

    public required Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
