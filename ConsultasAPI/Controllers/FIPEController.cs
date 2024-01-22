using ConsultasAPI.Domain.interfaces;
using ConsultasAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ConsultasAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FIPEController : ControllerBase
    {
        public readonly IFIPEService _fipeService;

        public FIPEController(IFIPEService fipeService)
        {
            _fipeService = fipeService;
        }

        [HttpGet("busca/veiculos/{tipoVeiculo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarVeiculos([FromRoute] string? tipoVeiculo)
        {
            var response = await _fipeService.BuscarVeiculos(tipoVeiculo);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("busca/{codigoFipe}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarPreco([FromRoute] string codigoFipe)
        {
            var response = await _fipeService.BuscarPreco(codigoFipe);

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
