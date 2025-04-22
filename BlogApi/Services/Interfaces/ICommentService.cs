using BlogApi.DTOs;
using BlogApi.Models;

namespace BlogApi.Services.Interfaces;

public interface ICommentService
{
    Task<List<Comment>> GetByPostIdAsync(string postId);
    Task<Comment> AddCommentAsync(string postId, CommentDto comment);
}
