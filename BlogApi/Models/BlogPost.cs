using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using BlogApi.DTOs;

namespace BlogApi.Models;

public class BlogPost
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
