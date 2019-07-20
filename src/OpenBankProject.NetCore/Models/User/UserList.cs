using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.User
{
    public class UserList : IEnumerableSource<Common.User>
    {
        public List<Common.User> Users { get; set; }
        public IEnumerable<Common.User> Items => Users;
    }
}
