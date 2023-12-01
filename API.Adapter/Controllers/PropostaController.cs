using API.Adapter.Application.DTO;
using API.Adapter.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace API.Adapter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropostaController : ControllerBase
    {
        private readonly IPropostaServices _propostaServices;
        public PropostaController(IPropostaServices propostaServices)
        {
            _propostaServices = propostaServices;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(PropostaBaseDto propostaDto)
        {
            try
            {
                await _propostaServices.AdicionarProposta(propostaDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
