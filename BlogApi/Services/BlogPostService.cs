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
        var result = new List<BlogPostWithCommentCountDto>();

        var posts = await postRepo.GetAllAsync();

        foreach (var post in posts)
        {
            var comments = await commentRepo.GetByPostIdAsync(post.Id);
            result.Add(new BlogPostWithCommentCountDto(post, comments.Count()));
        }

        return result;
    }

    public async Task<BlogPostDto> GetByIdAsync(string id)
    {
        var blogPost = await postRepo.GetByIdAsync(id);

        var blogPostDto = new BlogPostDto();
        blogPostDto.Text = blogPost.Text;
        blogPostDto.Title = blogPost.Title;

        var comments = await commentRepo.GetByPostIdAsync(blogPost.Id);
        if (!comments?.Any() ?? false)
        {
            return blogPostDto;
        }

        blogPostDto.Comments = comments;

        return blogPostDto;
    }

    public Task<BlogPost> CreateAsync(AddBlogPostDto postDto) 
    {
        var blogPost = new BlogPost();
        blogPost.Text = postDto.Text;
        blogPost.Title = postDto.Title;
        blogPost.CreatedAt = DateTime.UtcNow;

        return postRepo.CreateAsync(blogPost);
    }
}
