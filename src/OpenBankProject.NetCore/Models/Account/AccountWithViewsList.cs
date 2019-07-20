using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class AccountWithViewsList : IEnumerableSource<AccountWithViews>
    {
        public List<AccountWithViews> Accounts { get; set; }
        public IEnumerable<AccountWithViews> Items => Accounts;
    }
}
