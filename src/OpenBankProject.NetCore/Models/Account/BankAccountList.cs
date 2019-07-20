using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class BankAccountList : IEnumerableSource<BankAccount>
    {
        public List<BankAccount> Accounts { get; set; }
        public IEnumerable<BankAccount> Items => Accounts;
    }
}