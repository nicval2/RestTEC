using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class MovieController
{
    private MovieServices _movieServices = new MovieServices();

    [HttpPost("/movie")]
    public MovieDto CreateMovie([FromBody] MovieDto dto)
    {
        return _movieServices.Save(dto);
    }

    [HttpGet("/movie")]
    public List<MovieDto> GetAll()
    {
        return _movieServices.LoadArchive();
    }

    [HttpGet("/{id:int}/movie")]
    public MovieDto GetById(int id)
    {
        return _movieServices.Search(id);
    }
}