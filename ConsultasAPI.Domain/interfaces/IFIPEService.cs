using ConsultasAPI.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.interfaces
{
    public interface IFIPEService
    {
        Task<ResponseGenerico<List<VeiculosResponse>>> BuscarVeiculos(string? tipóVeiculo);
        Task<ResponseGenerico<List<PrecoResponse>>> BuscarPreco(string codigoFipe);
    }
}
