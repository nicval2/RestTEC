using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controller]")]
public class BillController
{
    private BillServices _billServices = new BillServices();

    [HttpPost("/bill")]
    public BillDto CreateBill([FromBody] BillDto dto)
    {
        return _billServices.Save(dto);
    }

    [HttpGet("/bill")]
    public List<BillDto> GetAll()
    {
        return _billServices.LoadArchive();
    }
    
    [HttpGet("/{id:int}/client")]
    public BillDto GetById(int id)
    {
        return _billServices.Search(id);
    }

    [HttpGet("/bill/{id:int}/total")]
    public int GetTotal(int id)
    {
        try
        {
            return _billServices.Total(GetById(id));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}