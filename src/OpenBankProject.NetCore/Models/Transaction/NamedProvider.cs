using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class NamedProvider : WithId
    {
        public string Provider { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}