using System;

namespace PropertyApp.Model
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int YearBuild { get; set; }
        public float ListPrice { get; set; }
        public float MonthlyPrice { get; set; }
        public float GrossYield { get; set; }
    }
}
