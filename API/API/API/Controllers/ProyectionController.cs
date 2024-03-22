using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class ProyectionController
{
    private ProyectionServices _proyectionServices = new ProyectionServices();

    [HttpPost("/projection")]
    public ProyectionDto CreateProyection([FromBody] ProyectionDto dto)
    {
        return _proyectionServices.Save(dto);
    }

    [HttpGet("/projection")]
    public List<ProyectionDto> GetAll()
    {
        return _proyectionServices.LoadArchive();
    }

    [HttpGet("/{id:int}/projection")]
    public ProyectionDto GetById(int id)
    {
        return _proyectionServices.Search(id);
    }
}