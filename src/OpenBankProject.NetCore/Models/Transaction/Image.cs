using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class Image : ImageInformation
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public NamedProvider User { get; set; }
    }
}