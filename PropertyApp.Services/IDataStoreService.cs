using System;
using System.Collections.Generic;
using System.Text;
using PropertyApp.Model;

namespace PropertyApp.Services
{
    public interface IDataStoreService
    {
        PropertyModel StoreProperty(PropertyModel propertyModel);
    }
}
