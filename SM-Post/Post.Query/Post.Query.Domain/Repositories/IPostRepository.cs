using Post.Query.Domain.Entities;

namespace Post.Post.Query.Repositories;
public interface IPostRepository
{
    Task CreateAsync(PostEntity post);
    Task UpdateAsync(PostEntity post);
    Task DeleteAsync(Guid postId);
    Task<PostEntity> GetByIdAsync(Guid postId);
    Task<List<PostEntity>> ListAllAsync(Guid postId);
    Task<List<PostEntity>> ListByAuthorAsync(string author);
    Task<List<PostEntity>> ListWithLikesAsync(int numberOfLikes);
    Task<List<PostEntity>> ListWithCommentsAsync();
}