using BlogApi.Models;

namespace BlogApi.DTOs;

public class AddBlogPostDto
{
    public string Title { get; set; }
    public string Text { get; set; }
}
