using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.BankAtm
{
    public class AtmList : IEnumerableSource<Atm>
    {
        public List<Atm> Atms { get; set; }
        public IEnumerable<Atm> Items => Atms;
    }
}
