using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class BankAccount : WithId
    {
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        public string Number { get; set; }
        [JsonProperty("account_routings")]
        public List<BankRouting> AccountRoutings { get; set; }
    }
}
