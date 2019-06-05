using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitServer.Models
{
    public class TestRequestDTO
    {
        public ICollection<long> EnumOne { get; set; }
        public ICollection<long> EnumTwo { get; set; }
        public string MethodString { get; set; }
    }
}
