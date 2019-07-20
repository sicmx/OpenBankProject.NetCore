using System;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Api
{
    public class AdapterInformation : VersionGitCommit
    {
        public string Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
