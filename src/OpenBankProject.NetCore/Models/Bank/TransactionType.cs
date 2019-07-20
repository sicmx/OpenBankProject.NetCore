using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.Bank
{
    public class TransactionType
    {
        public WithValue Id { get; set; }
        public WithValue BankId { get; set; }
        public string ShortCode { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public CurrencyAmount Charge { get; set; }
    }
}
