using Refit;
using RefitClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RefitClient.Services
{
    public interface IService
    {
     
        [Get("/api/Test/TestMethod")]        
        Task<HttpResponseMessage> TestMethod([Query]TestRequestDTO requestDTO);
    }
}
