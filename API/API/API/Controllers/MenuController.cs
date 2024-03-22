using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class MenuController
{
    private MenuServices _menuServices = new MenuServices();

    [HttpPost("/menu")]
    public Menu CrearPlato([FromBody] Menu me)
    {
        return _menuServices.Save(me);
    }

    [HttpGet("/menu")]
    public List<Menu> GetAll()
    {
        return _menuServices.LoadArchive();
    }

    [HttpGet("/{id:int}/menu")]
    public Menu GetById(int id)
    {
        return _menuServices.Search(id);
    }
}