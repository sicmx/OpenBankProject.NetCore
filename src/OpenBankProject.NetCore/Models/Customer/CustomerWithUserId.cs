using Newtonsoft.Json;

namespace OpenBankProject.NetCore.Models.Customer
{
    public class CustomerWithUserId : Customer
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}