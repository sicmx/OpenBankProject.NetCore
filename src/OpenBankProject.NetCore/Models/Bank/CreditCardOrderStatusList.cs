using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Bank
{
    public class CreditCardOrderStatusList : IEnumerableSource<CreditCardOrderStatus>
    {
        public List<CreditCardOrderStatus> Cards { get; set; }
        public IEnumerable<CreditCardOrderStatus> Items => Cards;
    }
}