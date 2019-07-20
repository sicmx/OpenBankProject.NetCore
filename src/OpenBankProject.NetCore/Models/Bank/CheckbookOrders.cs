using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Bank
{
    public class CheckbookOrders
    {
        public AccountInformation Account { get; set; }
        public List<OrderInformation> Orders { get; set; }
    }
}
