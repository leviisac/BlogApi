using BlogApi.Models;

namespace BlogApi.Repositories.Interfaces;

public interface ICommentRepository
{
    Task<List<Comment>> GetByPostIdAsync(string postId);
    Task<Comment> CreateAsync(Comment comment);
}