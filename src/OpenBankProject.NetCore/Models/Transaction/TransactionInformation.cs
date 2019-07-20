using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class TransactionInformation : WithId
    {
        [JsonProperty("this_account")]
        public MinimalTransactionAccount ThisAccount { get; set; }
        [JsonProperty("other_account")]
        public OtherMinimalTransactionAccount OtherAccount { get; set; }
        public TransactionDetails Details { get; set; }
    }
}
