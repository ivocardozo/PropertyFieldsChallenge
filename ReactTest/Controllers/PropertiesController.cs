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
        private readonly IDataStoreService dataStoreService;
        public PropertiesController(IDataRetrieveService dataRetrieveService, IDataStoreService dataStoreService)
        {
            this.dataRetrieveService = dataRetrieveService;
            this.dataStoreService = dataStoreService;
        }

        [HttpGet("properties")]
        public List<PropertyModel> GetProperties()
        {
            return dataRetrieveService.RetrieveProperties();
        }

        [HttpPost("property")]
        public PropertyModel PostProperty(PropertyModel propertyModel)
        {
            return dataStoreService.StoreProperty(propertyModel);
        }
    }
}
