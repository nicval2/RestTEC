using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class ProtagonistController
{
    private ProtagonistServices _protagonistServices = new ProtagonistServices();

    [HttpPost("/protagonist")]
    public ProtagonistDto CreateProtagonist([FromBody] ProtagonistDto dto)
    {
        return _protagonistServices.Save(dto);
    }

    [HttpGet("/protagonist")]
    public List<ProtagonistDto> GetAll()
    {
        return _protagonistServices.LoadArchive();
    }

    [HttpGet("/{id:int}/protagonist")]
    public ProtagonistDto GetById(int id)
    {
        return _protagonistServices.Search(id);
    }
}