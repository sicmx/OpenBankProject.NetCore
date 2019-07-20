using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Customer
{
    public class CustomerSocialMediaHandleList : IEnumerableSource<CustomerSocialMediaHandle>
    {
        public List<CustomerSocialMediaHandle> Checks { get; set; }
        public IEnumerable<CustomerSocialMediaHandle> Items => Checks;
    }
}
