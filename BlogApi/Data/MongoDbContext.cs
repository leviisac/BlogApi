using BlogApi.Data;
using BlogApi.Models;
using MongoDB.Driver;

namespace ApiProject.Services;

public class MongoDbContext : IMongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IConfiguration config)
    {
        var client = new MongoClient(config.GetValue<string>("MongoSettings:ConnectionString"));
        _database = client.GetDatabase(config.GetValue<string>("MongoSettings:DatabaseName"));
    }

    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _database.GetCollection<T>(name);
    }
    public IMongoCollection<BlogPost> BlogPosts => _database.GetCollection<BlogPost>("BlogPosts");

    public IMongoCollection<Comment> Comments => _database.GetCollection<Comment>("Comments");
}
