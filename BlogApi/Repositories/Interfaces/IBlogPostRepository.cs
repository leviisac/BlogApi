using BlogApi.Models;

namespace BlogApi.Repositories.Interfaces;

public interface IBlogPostRepository
{
    Task<List<BlogPost>> GetAllAsync();
    Task<BlogPost> GetByIdAsync(string id);
    Task<BlogPost> CreateAsync(BlogPost post);
}
