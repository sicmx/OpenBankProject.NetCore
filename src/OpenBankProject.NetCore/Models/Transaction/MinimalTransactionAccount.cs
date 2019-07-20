using System.Collections.Generic;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class MinimalTransactionAccount : MinimalTransactionAccountInformation
    {
        public List<Holder> Holders { get; set; }
    }
}