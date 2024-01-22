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
    public class PrecoMapping : Profile
    {
        public PrecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PrecoResponse, PrecoModel>();
            CreateMap<PrecoModel, PrecoResponse>();
        }
    }
}
