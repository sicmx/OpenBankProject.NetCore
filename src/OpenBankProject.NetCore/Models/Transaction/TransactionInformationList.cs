using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class TransactionInformationList : IEnumerableSource<TransactionInformation>
    {
        public List<TransactionInformation> Transactions { get; set; }
        public IEnumerable<TransactionInformation> Items => Transactions;
    }
}
