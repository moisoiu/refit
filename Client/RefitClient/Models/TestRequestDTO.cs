using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitClient.Models
{
    public class TestRequestDTO
    {
        public IEnumerable<long> EnumOne { get; set; }
        public IEnumerable<long> EnumTwo { get; set; }
        public string MethodString { get; set; }
    }
}
