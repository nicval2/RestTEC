using System.Runtime;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class TiposPlatosController
{
    private TiposPlatosServices _TiposPlatosServices = new TiposPlatosServices();

    [HttpPost("/tiposplatos")]
    public TiposPlatos CrearTipoPlato([FromBody] TiposPlatos pl)
    {
        return _TiposPlatosServices.Save(pl);
    }

    [HttpGet("/tiposplatos")]
    public List<TiposPlatos> GetAll()
    {
        return _TiposPlatosServices.LoadArchive();
    }

    [HttpGet("/{id:int}/tiposplatos")]
    public TiposPlatos GetById(int id)
    {
        return _TiposPlatosServices.Search(id);
    }

    [HttpDelete("/{id:int}/tiposplatos")]
    public TiposPlatos DeleteByID(TiposPlatos pl,int id){
        return _TiposPlatosServices.Update(pl, id);
    }

    }

