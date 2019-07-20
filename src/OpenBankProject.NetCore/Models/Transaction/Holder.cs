using Newtonsoft.Json;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class Holder
    {
        public string Name { get; set; }
        [JsonProperty("is_alias")]
        public bool IsAlias { get; set; }
    }
}