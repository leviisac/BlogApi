using BlogApi.Data;
using BlogApi.Models;
using BlogApi.Repositories.Interfaces;
using MongoDB.Driver;

namespace BlogApi.Repositories;

public class CommentRepository: ICommentRepository
{
    private readonly IMongoCollection<Comment> _collection;

    public CommentRepository(IMongoDbContext context)
    {
        _collection = context.Comments;
    }

    public Task<List<Comment>> GetByPostIdAsync(string postId) =>
        _collection.Find(c => c.PostId == postId).ToListAsync();

    public async Task<Comment> CreateAsync(Comment comment)
    {
        await _collection.InsertOneAsync(comment);
        return comment;
    }
}
