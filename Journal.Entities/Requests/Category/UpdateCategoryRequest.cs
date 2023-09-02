namespace Journal.Entities.Requests.Category;

public class UpdateCategoryReqeust
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
}
