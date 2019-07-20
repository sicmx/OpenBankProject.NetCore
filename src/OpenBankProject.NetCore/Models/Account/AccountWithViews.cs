﻿using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class AccountWithViews : WithId
    {
        public string Label { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
        [JsonProperty("account_routings")]
        public List<BankRouting> AccountRoutings { get; set; }
        public List<View> Views { get; set; }
    }
}
