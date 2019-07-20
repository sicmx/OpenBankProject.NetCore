using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Customer
{
    public class CustomerList : IEnumerableSource<Customer>
    {
        public List<Customer> Customers { get; set; }
        public IEnumerable<Customer> Items => Customers;
    }
}
