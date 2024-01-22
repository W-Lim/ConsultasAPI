using ConsultasAPI.Domain.DTOs;
using ConsultasAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.interfaces
{
    public interface IBrasilAPI
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
        Task<ResponseGenerico<List<FeriadosModel>>> BuscarFeriados(string ano);
        Task<ResponseGenerico<List<VeiculosModel>>> BuscarVeiculos(string? tipoVeiculo);
        Task<ResponseGenerico<List<PrecoModel>>> BuscarPreco(string codigoFipe);
    }
}
