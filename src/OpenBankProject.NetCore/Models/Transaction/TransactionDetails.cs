﻿using System;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class TransactionDetails
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Posted { get; set; }
        public DateTime Completed { get; set; }
        [JsonProperty("new_balance")]
        public CurrencyAmount NewBalance { get; set; }
        public CurrencyAmount Value { get; set; }
    }
}