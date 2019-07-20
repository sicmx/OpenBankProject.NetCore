using Newtonsoft.Json;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class BankInformation
    {
        [JsonProperty("national_identifier")]
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
    }
}