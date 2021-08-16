using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatrykKaczynskiLab6ZadDom.Infrastructure.DTO;
using PatrykKaczynskiLab6ZadDom.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinesController : ControllerBase
    {
        private readonly IWineService _wineService;
        public WinesController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var wines = _wineService.GetAll();

            return Ok(wines);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var wine = _wineService.Get(id);
            if (wine == null)
            {
                return NotFound();
            }

            return Ok(wine);
        }

        [HttpPost]
        public IActionResult Post([FromBody] WineDto wine)
        {
            var newId = Guid.NewGuid();
            wine = _wineService.Post(newId, wine.Name, wine.ProducerName, wine.ProductionYear, wine.CountryName, wine.Color, wine.Taste, wine.AlcoholContent);
            return Created($"api/wines/{newId}", wine);
        }

        [HttpPut("id")]
        public IActionResult Put(Guid id, [FromBody] WineDto wine)
        {
            _wineService.Put(id, wine.Name, wine.ProducerName, wine.ProductionYear, wine.CountryName, wine.Color, wine.Taste, wine.AlcoholContent);
         
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            _wineService.Delete(id);
            return NoContent();
        }
    }
}
