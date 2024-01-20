using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.DTOs
{
    public class BancoResponse
    {
        public string? Ispb {  get; set; }
        public string? NomeAbreviado { get; set; }
        public int Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}
