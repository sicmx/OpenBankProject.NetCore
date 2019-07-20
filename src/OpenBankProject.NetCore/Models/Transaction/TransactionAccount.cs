using System.Collections.Generic;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class TransactionAccount : TransactionAccountInformation
    {
        public List<Holder> Holders { get; set; }
    }
}