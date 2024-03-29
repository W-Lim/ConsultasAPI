﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsultasAPI.Domain.DTOs
{
    public class FeriadosResponse
    {
        public string? Data { get; set; }
        public string? Nome { get; set; }
        [JsonIgnore]
        public string? Type { get; set; }
    }
}
