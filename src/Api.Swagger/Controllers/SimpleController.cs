using Api.Swagger.Models;
using Api.Swagger.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Swagger.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleController : ControllerBase
{
    private readonly ICountService _countService;

    public SimpleController(ICountService countService)
    {
        _countService = countService;
    }

    /// <summary>
    /// Возвращает число, которое обозначает, сколько раз был вызван этот метод.
    /// </summary>
    /// <returns>Число, которое обозначает, сколько раз был вызван этот метод.</returns>
    [HttpGet("count")]
    public int GetCount()
    {
        return _countService.Count;
    }

    /// <summary>
    /// Возвращает заполненную <see cref="SampleModel"/>.
    /// </summary>
    /// <returns><see cref="SampleModel"/>.</returns>
    [HttpGet("model")]
    public SampleModel GetSampleModel()
    {
        return new SampleModel(HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Привет, мир!", Random.Shared.Next());
    }
}