using Microsoft.AspNetCore.Mvc;
using System;

namespace PrimaryConstructorApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger logger, IWeatherService weatherService) : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        logger.LogInformation("Inside get weather method");
        return Enumerable.Range(1, 5).Select(weatherService.GetWeatherForecast)
            .ToArray();
    }
}

public interface IWeatherService
{
    WeatherForecast GetWeatherForecast(int days);
}

internal class WeatherService: IWeatherService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public WeatherForecast GetWeatherForecast(int days)
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(days)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
}