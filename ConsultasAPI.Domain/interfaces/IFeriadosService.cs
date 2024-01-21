using ConsultasAPI.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.interfaces
{
    public interface IFeriadosService
    {
        Task<ResponseGenerico<List<FeriadosResponse>>> BuscarFeriados(string ano);
    }
}
