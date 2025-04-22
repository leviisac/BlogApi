using BlogApi.Models;

namespace BlogApi.DTOs;

public class BlogPostDto
{
    public string Title { get; set; }
    public string Text { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
