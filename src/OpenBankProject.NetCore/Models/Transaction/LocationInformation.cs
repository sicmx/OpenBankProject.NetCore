using System;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Transaction
{
    public class LocationInformation : Location
    {
        public DateTime? Date { get; set; }
        public NamedProvider User { get; set; }
    }
}