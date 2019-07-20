using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public abstract class TransactionAccountInformation : WithId
    {
        public string Number { get; set; }
        public string Kind { get; set; }
        [JsonProperty("IBAN")]
        public string Iban { get; set; }
        [JsonProperty("swift_bic")]
        public string SwiftBic { get; set; }
        public BankInformation Bank { get; set; }
    }
}