using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyApp.Model
{
    public class PropertyObject
    {
        public List<Property> Properties { get; set; }
    }
    public class Property
    {
        public int Id { get; set; }
        public bool IsAllowOffer { get; set; }
        public Address Address { get; set; }
        public Physical Physical { get; set; }
        public Financial Financial { get; set; }
    }

    public class Address
    {
        public string Address1 { get; set; }
    }

    public class Physical
    {
        public int YearBuilt { get; set; }
    }

    public class Financial
    {
        public float ListPrice { get; set; }
        public float MonthlyRent { get; set; }
    }

}
