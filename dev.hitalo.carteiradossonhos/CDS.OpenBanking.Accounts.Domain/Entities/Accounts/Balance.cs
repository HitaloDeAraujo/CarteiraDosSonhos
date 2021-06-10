namespace CDS.OpenBanking.Accounts.Domain.Entities.Accounts
{
    public class Balance
    {
        public decimal AvailableAmount { get; set; }
        public string AvailableAmountCurrency { get; set; }
        public decimal BlockedAmount { get; set; }
        public string BlockedAmountCurrency { get; set; }
        public decimal AutomaticallyInvestedAmount { get; set; }
        public string AutomaticallyInvestedAmountCurrency { get; set; }
    }
}