namespace OpenBankProject.NetCore.Models.Transaction
{
    public class OtherTransactionAccount : TransactionAccountInformation
    {
        public Holder Holder { get; set; }
        public TransactionAccountMetadata Metadata { get; set; }
    }
}
