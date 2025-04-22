using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Repositories.Interfaces;
using BlogApi.Services.Interfaces;

namespace BlogApi.Services;

public class CommentService(ICommentRepository commentRepo) : ICommentService
{
    public Task<List<Comment>> GetByPostIdAsync(string postId) => commentRepo.GetByPostIdAsync(postId);

    public Task<Comment> AddCommentAsync(string postId, CommentDto commentDto) {

        var comment = new Comment();
        comment.Author = commentDto.Author;
        comment.Text = commentDto.Text;
        comment.CreatedAt = DateTime.UtcNow;
        comment.PostId = postId;

        return commentRepo.CreateAsync(comment);
    }
}
