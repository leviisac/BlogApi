using BlogApi.DTOs;
using BlogApi.Models;

namespace BlogApi.Services.Interfaces;

public interface IBlogPostService
{
    Task<List<BlogPostWithCommentCountDto>> GetAllPostsWithCommentCountAsync();
    Task<BlogPost> GetByIdAsync(string id);
    Task<BlogPost> CreateAsync(BlogPostDto postDto);
}
