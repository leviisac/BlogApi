using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[ApiController]
[Route("api/posts/{postId}/[controller]")]
public class CommentsController(ICommentService commentService) : ControllerBase
{
    /// <summary>
    /// Add a new comment to a specific blog post.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> AddComment(string postId, [FromBody] CommentDto commentDto)
    {
        var commentReponse = await commentService.AddCommentAsync(postId, commentDto);
        return Ok(commentReponse);
    }
}
