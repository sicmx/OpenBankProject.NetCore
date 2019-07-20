using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Bank
{
    public class BankList : IEnumerableSource<Bank>
    {
        public List<Bank> Banks { get; set; }
        public IEnumerable<Bank> Items => Banks;
    }
}
