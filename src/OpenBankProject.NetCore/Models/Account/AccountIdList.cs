using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class AccountIdList : IEnumerableSource<WithId>
    {
        public List<WithId> Accounts { get; set; }
        public IEnumerable<WithId> Items => Accounts;
    }
}
