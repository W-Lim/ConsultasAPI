using ConsultasAPI.Domain.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ConsultasAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeriadosController : ControllerBase
    {
        public readonly IFeriadosService _feriadosService;

        public FeriadosController(IFeriadosService feriadosService)
        {
            _feriadosService = feriadosService;
        }

        [HttpGet("busca/{ano}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarFeriados([FromRoute] string ano)
        {
            var response = await _feriadosService.BuscarFeriados(ano);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
