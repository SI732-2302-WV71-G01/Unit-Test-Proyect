﻿using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services.Communication;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Domain.Repositories;

namespace LearningCenter.API.Learning.Domain.Services;

public interface IArticleService
{
    Task<IEnumerable<Article>> ListAsync();
    Task<ArticleResponse> SaveAsync(Article article);
    Task<IEnumerable<Article>> ListByUserIdAsync(int userId);
    Task<ArticleResponse> UpdateAsync(int idArticle, Article article);
    Task<ArticleResponse> DeleteAsync(int idArticle);
    
}