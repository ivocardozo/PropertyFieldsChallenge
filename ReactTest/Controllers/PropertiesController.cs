using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyApp.Services;
using PropertyApp.Model;

namespace ReactTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly IDataRetrieveService dataRetrieveService;
        public PropertiesController(IDataRetrieveService dataRetrieveService)
        {
            this.dataRetrieveService = dataRetrieveService;
        }

        [HttpGet("properties")]
        public List<PropertyModel> GetProperties()
        {
            return dataRetrieveService.RetrieveProperties();
        }
    }
}
