using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Api
{
    public class ApiInformation : VersionGitCommit
    {
        [JsonProperty("version_status")]
        public string VersionStatus { get; set; }
        public string Connector { get; set; }
        [JsonProperty("hosted_by")]
        public HostedBy HostedBy { get; set; }
        public Akka Akka { get; set; }
    }
}
