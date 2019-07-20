using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.ApiDocumentation
{
    public class MessageDocList : IEnumerableSource<MessageDoc>
    {
        public List<MessageDoc> MessageDocs { get; set; }
        public IEnumerable<MessageDoc> Items => MessageDocs;
    }
}
