using System.Collections.Generic;

namespace OpenBankProject.NetCore.Models.Api
{
    public class ElasticSearch
    {
        public List<PropertyValue> Metrics { get; set; }
        public List<PropertyValue> Warehouse { get; set; }
    }
}