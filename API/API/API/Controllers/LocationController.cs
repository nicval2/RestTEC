using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class LocationController
{
    private LocationServices _locationServices = new LocationServices();

    [HttpPost("/location")]
    public LocationDto CreateLocation([FromBody] LocationDto dto)
    {
        return _locationServices.Save(dto);
    }

    [HttpGet("/location")]
    public List<LocationDto> GetAll()
    {
        return _locationServices.LoadArchive();
    }

    [HttpGet("/{id:int}/location")]
    public LocationDto GetById(int id)
    {
        return _locationServices.Search(id);
    }
}