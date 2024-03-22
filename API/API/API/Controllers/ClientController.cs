using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
public class ClientController
{
    
    private ClientServices _clientServices = new ClientServices();

    [HttpPost("/client")]
    public ClientDto Save([FromBody] ClientDto dto)
    {
        return _clientServices.Save(dto);
    }

    [HttpPut ("/client/id")]
    public ClientDto Update( int id,[FromBody] ClientDto dto)
    {
        return _clientServices.Update(dto, id);
    }

    [HttpGet("/client")]
    public List<ClientDto> GetAll()
    {
        return _clientServices.LoadArchive();
    }
    
    [HttpGet("/{id:int}/client")]
    public ClientDto Search(int id)
    {
        return _clientServices.Search(id);
    }

    [HttpGet ("/client/size")]
    public int Size()
    {
        return _clientServices.Size();
    }
    
    [HttpGet ("/client/ssn")]
    public ClientDto SearchById(int ssn)
    {
        return _clientServices.Element(ssn);
    }
    
    [HttpGet ("/client/age")]
    public int GetAge([FromBody] ClientDto dto)
    {
        return _clientServices.Age(dto);
    }
    
}