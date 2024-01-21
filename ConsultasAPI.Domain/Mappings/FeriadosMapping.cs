using AutoMapper;
using ConsultasAPI.Domain.DTOs;
using ConsultasAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.Mappings
{
    public class FeriadosMapping : Profile
    {
        public FeriadosMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<FeriadosResponse, FeriadosModel>();
            CreateMap<FeriadosModel, FeriadosResponse>();
        }
    }
}
