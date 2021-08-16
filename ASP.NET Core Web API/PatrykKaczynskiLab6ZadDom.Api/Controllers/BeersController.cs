using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatrykKaczynskiLab6ZadDom.Core.Models;
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
    public class BeersController : ControllerBase
    {
        private readonly IBeerService _beerService;
        public BeersController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var beers = _beerService.GetAll();

            return Ok(beers);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var beer = _beerService.Get(id);
            if (beer == null)
            {
                return NotFound();
            }

            return Ok(beer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BeerDto beer)
        {
            var newId = Guid.NewGuid();
            beer = _beerService.Post(newId, beer.Name, beer.ProducerName, beer.Style, beer.ExtractContent, beer.AlcoholContent, beer.BitternessContent);
            return Created($"api/beers/{newId}", beer);
        }

        [HttpPut("id")]
        public IActionResult Put(Guid id, [FromBody] BeerDto beer)
        {
            _beerService.Put(id, beer.Name, beer.ProducerName, beer.Style, beer.ExtractContent, beer.AlcoholContent, beer.BitternessContent);
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            _beerService.Delete(id);
            return NoContent();
        }
    }
}
