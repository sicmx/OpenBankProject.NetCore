using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.ApiDocumentation
{
    public class GlossaryItemList : IEnumerableSource<GlossaryItem>
    {
        [JsonProperty("glossary_items")]
        public List<GlossaryItem> GlossaryItems { get; set; }
        public IEnumerable<GlossaryItem> Items => GlossaryItems;
    }
}
