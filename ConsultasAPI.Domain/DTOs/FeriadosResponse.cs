using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.DTOs
{
    public class FeriadosResponse
    {
        public string? Date { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
