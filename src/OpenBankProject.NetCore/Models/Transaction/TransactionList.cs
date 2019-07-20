using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class TransactionList : IEnumerableSource<Transaction>
    {
        public List<Transaction> Transactions { get; set; }
        public IEnumerable<Transaction> Items => Transactions;
    }
}
