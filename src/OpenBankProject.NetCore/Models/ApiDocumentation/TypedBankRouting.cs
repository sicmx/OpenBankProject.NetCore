﻿namespace OpenBankProject.NetCore.Models.ApiDocumentation
{
    public class TypedBankRouting : WithType
    {
        public BankRoutingType Properties { get; set; }
    }
}