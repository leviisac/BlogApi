using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Repositories;
using BlogApi.Repositories.Interfaces;
using BlogApi.Services.Interfaces;

namespace BlogApi.Services;

public class CommentService(
    ICommentRepository commentRepository,
    IBlogPostRepository blogPostRepository) : ICommentService
{
    public Task<List<Comment>> GetByPostIdAsync(string postId) => commentRepository.GetByPostIdAsync(postId);

    public async Task<Comment> AddCommentAsync(string postId, CommentDto commentDto)
    {
        var post = await blogPostRepository.GetByIdAsync(postId);
        if (post is null)
        {
            throw new KeyNotFoundException("Blog post not found");
        }

        var comment = new Comment
        {
            PostId = postId,
            Title = commentDto.Title,
            Text = commentDto.Text,
            CreatedAt = DateTime.UtcNow
        };

        return await commentRepository.CreateAsync(comment);
    }
}
