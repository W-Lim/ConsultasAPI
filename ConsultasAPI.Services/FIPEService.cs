using AutoMapper;
using ConsultasAPI.Domain.DTOs;
using ConsultasAPI.Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Services
{
    public class FIPEService : IFIPEService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilApi;

        public FIPEService(IMapper mapper, IBrasilAPI brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<PrecoResponse>>> BuscarPreco(string codigoFipe)
        {
            var preco = await _brasilApi.BuscarPreco(codigoFipe);

            return _mapper.Map<ResponseGenerico<List<PrecoResponse>>>(preco);
        }

        public async Task<ResponseGenerico<List<VeiculosResponse>>> BuscarVeiculos(string? tipóVeiculo)
        {
            var veiculos = await _brasilApi.BuscarVeiculos(tipóVeiculo);

            return _mapper.Map<ResponseGenerico<List<VeiculosResponse>>>(veiculos);
        }
    }
}
