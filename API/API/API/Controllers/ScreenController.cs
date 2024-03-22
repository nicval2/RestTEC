using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class ScreenController
{
    private ScreenServices _screenServices = new ScreenServices();

    [HttpPost("/screen")]
    public ScreenDto CreateScreen([FromBody] ScreenDto dto)
    {
        return _screenServices.Save(dto);
    }

    [HttpGet("/screen")]
    public List<ScreenDto> GetAll()
    {
        return _screenServices.LoadArchive();
    }

    [HttpGet("/{id:int}/screen")]
    public ScreenDto GetById(int id)
    {
        return _screenServices.Search(id);
    }

    [HttpGet("/screen/{id:int}/capacity")]
    public int GetCapacity(int id)
    {
        return _screenServices.Capacity(GetById(id));
    }
}