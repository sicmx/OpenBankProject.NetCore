using Newtonsoft.Json;

namespace OpenBankProject.NetCore.Models.Common
{
    public abstract class VersionGitCommit
    {
        public string Version { get; set; }
        [JsonProperty("git_commit")]
        public string GitCommit { get; set; }
    }
}
