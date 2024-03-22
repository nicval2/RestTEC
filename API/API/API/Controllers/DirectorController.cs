using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class DirectorController
{
    private DirectorServices _directorServices = new DirectorServices();

    [HttpPost("/director")]
    public DirectorDto CreateDirector([FromBody] DirectorDto dto)
    {
        return _directorServices.Save(dto);
    }

    [HttpGet("/director")]
    public List<DirectorDto> GetAll()
    {
        return _directorServices.LoadArchive();
    }

    [HttpGet("/{id:int}/director")]
    public DirectorDto GetById(int id)
    {
        return _directorServices.Search(id);
    }
}