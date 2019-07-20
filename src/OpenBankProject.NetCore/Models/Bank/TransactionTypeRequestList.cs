using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Bank
{
    public class TransactionTypeRequestList : IEnumerableSource<TransactionTypeRequest>
    {
        [JsonProperty("transaction_types")]
        public List<TransactionTypeRequest> TransactionTypes { get; set; }

        public IEnumerable<TransactionTypeRequest> Items => TransactionTypes;
    }
}
