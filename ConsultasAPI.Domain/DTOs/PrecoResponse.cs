using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.DTOs
{
    public class PrecoResponse
    {
        public string? Valor { get; set; }

        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public int? AnoModelo { get; set; }

        public string? Combustivel { get; set; }

        public string? CodigoFipe { get; set; }

        public string? MesReferencia { get; set; }

        public int? TipoVeiculo { get; set; }

        public string? SiglaCombustivel { get; set; }

        public string? DataConsulta { get; set; }
    }
}
