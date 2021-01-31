using PropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PropertyApp.Services
{
    public class DataRetrieveService : IDataRetrieveService
    {
        private const string URL_RETRIEVE_PROPERTIES = "https://samplerspubcontent.blob.core.windows.net/public/properties.json";
        public List<PropertyModel> RetrieveProperties()
        {
            return FetchData().Result;
        }

        public async Task<List<PropertyModel>> FetchData()
        {
            var httpClient = HttpClientFactory.Create();
            var httpResponse = await httpClient.GetAsync(URL_RETRIEVE_PROPERTIES);
            var properties = DeserializeJson(httpResponse).Result;
            return properties;
        }

        private async Task<List<PropertyModel>> DeserializeJson(HttpResponseMessage httpResponseMessage)
        {
            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            var responseElements = JsonConvert.DeserializeObject<PropertyObject>(responseContent);
            var properties = MapResponseMessageToList(responseElements.Properties);

            return properties;
        }
        private List<PropertyModel> MapResponseMessageToList(List<Property> properties)
        {
            List<PropertyModel> propertyModels = new List<PropertyModel>();
            foreach (Property property in properties)
            {
                propertyModels.Add(CreatePropertyModelFromProperty(property));
            }
            return propertyModels;
        }
        private PropertyModel CreatePropertyModelFromProperty(Property property)
        {
            return new PropertyModel
            {
                Address = property.Address.Address1,
                YearBuild = property.Financial != null ? property.Physical.YearBuilt : 0,
                MonthlyPrice = property.Financial != null ? property.Financial.MonthlyRent : 0,
                ListPrice = property.Financial != null ? property.Financial.ListPrice : 0,
                GrossYield = property.Financial != null ? (property.Financial.MonthlyRent * 12) / property.Financial.ListPrice : 0
            };
        }
    }
}
