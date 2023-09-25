using LearningCenter.API.Security.Domain.Models;

namespace LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Domain.Repositories;

//Lista de Articulos que pertenecen a los usuarios
public class Article
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    //
    public int UserId { get; set; }
    public User User { get; set; }

}