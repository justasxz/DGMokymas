using DGMokymas8_API.DTOS;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace DGMokymas8_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //weatherforecast/vardukas
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("vardukas")] // endpoint
        public string PostVardas(PersonDTO zmogus) // Get mes naudojam atskirus parametrus su Post visad naudojam faila/kita klase, nebent yra tik vienas parametras
        {
            //jeigu klaida
            //return BadRequest("Ivyko klaida")
            return $"Sveiki, {zmogus.Vardas} {zmogus.Pavarde}";
        }

        [HttpGet("vardukas")] // endpoint
        public async Task<IActionResult> GetVardas(string vardas, string pavarde) 
        {
            //jeigu klaida
            //return BadRequest("Ivyko klaida")
            var zmogus = new PersonDTO { Vardas = vardas, Pavarde = pavarde };
            return Ok(zmogus);
        }
    }
}
