using System;
using PropertyApp.Model;
namespace PropertyApp.Data
{
    public interface IDataRepository
    {
        PropertyModel PostProperty(PropertyModel propertyModel);
        PropertyModel GetPropertyModelById(int id);
    }
}
