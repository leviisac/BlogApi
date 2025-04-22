using BlogApi.Data;
using BlogApi.Models;
using BlogApi.Repositories.Interfaces;
using MongoDB.Driver;
namespace BlogApi.Repositories;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly IMongoCollection<BlogPost> _collection;

    public BlogPostRepository(IMongoDbContext context)
    {
        _collection = context.BlogPosts;
    }

    public Task<List<BlogPost>> GetAllAsync() =>
        _collection.Find(_ => true).ToListAsync();

    public Task<BlogPost> GetByIdAsync(string id) =>
        _collection.Find(p => p.Id == id).FirstOrDefaultAsync();

    public async Task<BlogPost> CreateAsync(BlogPost post)
    {
        await _collection.InsertOneAsync(post);
        return post;
    }

}
