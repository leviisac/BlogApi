using BlogApi.Models;
using MongoDB.Driver;

namespace BlogApi.Data;

public interface IMongoDbContext
{
    IMongoCollection<BlogPost> BlogPosts { get; }
    IMongoCollection<Comment> Comments { get; }
}
