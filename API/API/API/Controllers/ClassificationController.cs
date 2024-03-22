using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/[controler]")]
public class ClassificationController
{
    private ClassificationServices _classificationServices = new ClassificationServices();

    [HttpPost("/classification")]
    public ClassificationDto CreateClassification([FromBody] ClassificationDto dto)
    {
        return _classificationServices.Save(dto);
    }

    [HttpGet("/classification")]
    public List<ClassificationDto> GetAll()
    {
        return _classificationServices.LoadArchive();
    }

    [HttpGet("/{id:int}/classification")]
    public ClassificationDto GetById(int id)
    {
        return _classificationServices.Search(id);
    }
}