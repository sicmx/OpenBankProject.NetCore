﻿using System;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class DatedIdValue
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public NamedProvider User { get; set; }
    }
}