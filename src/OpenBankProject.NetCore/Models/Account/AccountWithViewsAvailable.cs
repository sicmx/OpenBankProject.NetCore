﻿using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Account
{
    public class AccountWithViewsAvailable
    {
        public string Id { get; set; }
        public string Label { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        public List<AvailableView> ViewsAvailable { get; set; }
    }
}
