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
    public class FeriadosService : IFeriadosService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilApi;

        public FeriadosService(IMapper mapper, IBrasilAPI brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<FeriadosResponse>>> BuscarFeriados(string ano)
        {
            var feriados = await _brasilApi.BuscarFeriados(ano);

            return _mapper.Map<ResponseGenerico<List<FeriadosResponse>>>(feriados);
        }
    }
}
