using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Consumer
{
    public class ConsumerList : IEnumerableSource<Consumer>
    {
        public List<Consumer> List { get; set; }
        public IEnumerable<Consumer> Items => List;
    }
}
