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
    public class VeiculosMapping : Profile
    {
        public VeiculosMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<VeiculosResponse, VeiculosModel>();
            CreateMap<VeiculosModel, VeiculosResponse>();
        }
    }
}
