using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.Models;

namespace Revisao.API.Controllers
{
    

    
        [Route("api/cartinhas")]
        [ApiController]
        public class CartasController : ControllerBase
        {
            private readonly ICartaService _cartaService;

            public CartasController(ICartaService cartaService)
            {
                _cartaService = cartaService;
            }

            [HttpPost]
            public IActionResult EnviarCartinha([FromBody] NovaCartaModel novaCarta)
            {
                var carta = _cartaService.EnviarCartinha(novaCarta);
                return Ok(carta);
            }

            [HttpGet]
            public IActionResult ListarCartinhas()
            {
                var cartinhas = _cartaService.ListarCartinhas();
                return Ok(cartinhas);
            }
        }
}
