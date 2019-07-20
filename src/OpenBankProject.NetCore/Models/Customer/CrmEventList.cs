using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Customer
{
    public class CrmEventList : IEnumerableSource<CrmEvent>
    {
        [JsonProperty("crm_events")]
        public List<CrmEvent> CrmEvents { get; set; }

        public IEnumerable<CrmEvent> Items => CrmEvents;
    }
}
