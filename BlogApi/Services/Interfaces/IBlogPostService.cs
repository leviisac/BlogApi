using BlogApi.DTOs;
using BlogApi.Models;

namespace BlogApi.Services.Interfaces;

public interface IBlogPostService
{
    Task<List<BlogPostWithCommentCountDto>> GetAllPostsWithCommentCountAsync();
    Task<BlogPostDto> GetByIdAsync(string id);
    Task<BlogPost> CreateAsync(AddBlogPostDto postDto);
}
