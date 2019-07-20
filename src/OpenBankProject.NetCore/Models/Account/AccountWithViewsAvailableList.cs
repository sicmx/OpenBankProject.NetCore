using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class AccountWithViewsAvailableList : IEnumerableSource<AccountWithViewsAvailable>
    {
        public List<AccountWithViewsAvailable> Accounts { get; set; }
        public IEnumerable<AccountWithViewsAvailable> Items => Accounts;
    }
}
