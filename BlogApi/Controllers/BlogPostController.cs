using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogPostController(IBlogPostService blogPostService) : ControllerBase
{
    /// <summary>
    /// Get all blog posts with their comment count.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllPosts()
    {
        var posts = await blogPostService.GetAllPostsWithCommentCountAsync();
        return Ok(posts);
    }

    /// <summary>
    /// Get a specific blog post by ID including its comments.
    /// </summary>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPost(string id)
    {
        var post = await blogPostService.GetByIdAsync(id);
        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }

    /// <summary>
    /// Create a new blog post.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] BlogPostDto blogPostDto)
    {
        var postResponse = await blogPostService.CreateAsync(blogPostDto);
        return Ok(postResponse);
    }
}