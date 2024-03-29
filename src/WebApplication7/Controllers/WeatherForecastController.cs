﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Consulta de Temperatura Geral
        /// </summary>
        /// <returns>algumas temperaturas</returns>
        /// <remarks>
        /// Exemplo de Chamada:
        ///     GET /WeatherForecast
        /// </remarks>
        /// <response code="200">Retorna a temperatura em ceucius</response>
        /// <response code="400">If the item is null</response>
        [HttpGet]
        [Produces("application/json",Type = typeof(WeatherForecast))]
        public async Task<IActionResult> Get()
        {
           // WeatherForecast


            var rng = new Random();
            var response =Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            return Ok(response);
            //return RestResult<WeatherForecast>();
        }
    }
}
