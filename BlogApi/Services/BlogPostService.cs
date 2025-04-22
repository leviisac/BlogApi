using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Repositories.Interfaces;
using BlogApi.Services.Interfaces;

namespace BlogApi.Services;

public class BlogPostService(
    IBlogPostRepository postRepo,
    ICommentRepository commentRepo) : IBlogPostService
{
    public async Task<List<BlogPostWithCommentCountDto>> GetAllPostsWithCommentCountAsync()
    {
        var posts = await postRepo.GetAllAsync();
        var result = new List<BlogPostWithCommentCountDto>();

        foreach (var post in posts)
        {
            var comments = await commentRepo.GetByPostIdAsync(post.Id);
            result.Add(new BlogPostWithCommentCountDto(post, comments.Count()));
        }

        return result;
    }

    public Task<BlogPost> GetByIdAsync(string id) => postRepo.GetByIdAsync(id);

    public Task<BlogPost> CreateAsync(BlogPostDto postDto) 
    {
        var blogPost = new BlogPost();
        blogPost.Text = postDto.Text;
        blogPost.Author = postDto.Author;
        blogPost.CreatedAt = DateTime.UtcNow;

        return postRepo.CreateAsync(blogPost);
    }
}
