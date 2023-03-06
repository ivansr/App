using App.Application.Interfaces;
using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : ControllerBase
    {
        private readonly ILogger<PruebaController> _logger;
        private readonly IPruebaService _pruebaService;
        public PruebaController(ILogger<PruebaController> logger, IPruebaService pruebaService)
        {
            _logger = logger;
            _pruebaService = pruebaService;
        }

        [HttpGet(Name = "GetPruebas")]
        public async Task<IEnumerable<Prueba>> Get()
        {
            return await _pruebaService.GetAllAsync();
        }

        [HttpGet("{id}",Name = "GetPrueba")]
        public async Task<Prueba> Get(int id)
        {
            return await _pruebaService.GetByIdAsync(id);
        }
    }
}

