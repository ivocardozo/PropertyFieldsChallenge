using PropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PropertyApp.Data;

namespace PropertyApp.Services
{
    public class DataStoreService : IDataStoreService
    {
        private readonly IDataRepository dataRepository;

        public DataStoreService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public PropertyModel StoreProperty(PropertyModel propertyModel)
        {
            return dataRepository.PostProperty(propertyModel);
        }
    }
}
