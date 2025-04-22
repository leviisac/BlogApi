using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BlogApi.Models;

public class Comment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Title { get; set; }
    public string PostId { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
