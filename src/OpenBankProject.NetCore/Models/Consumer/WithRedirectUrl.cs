using Newtonsoft.Json;

namespace OpenBankProject.NetCore.Models.Consumer
{
    public class WithRedirectUrl
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}