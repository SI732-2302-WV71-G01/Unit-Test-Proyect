using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Security.Domain.Models;

using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Domain.Repositories;

namespace LearningCenter.API.Learning.Domain.Repositories;

public interface IArticlerRepository
{
    Task<IEnumerable<Article>> ListAsync();
    Task AddAsync(Article article);
    Task<Article> FindByIdAsync(int id);
    Task<IEnumerable<Article>> FindByUserIdAsync(int userId);
    void Update(Article store);
    void Remove(Article store);
}