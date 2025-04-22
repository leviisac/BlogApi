using BlogApi.Models;

namespace BlogApi.DTOs;

public record BlogPostWithCommentCountDto
{
    public BlogPost Post { get; }

    public int CommentCount { get; }

    public BlogPostWithCommentCountDto(BlogPost post, int commentCount)
    {
        Post = post;
        CommentCount = commentCount;
    }
}
