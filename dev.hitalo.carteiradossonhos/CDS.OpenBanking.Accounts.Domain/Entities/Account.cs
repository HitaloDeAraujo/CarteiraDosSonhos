namespace CDS.OpenBanking.Accounts.Domain.Entities
{
    public class Account
    {
        public string BrandName { get; set; }
        public string CompanyCnpj { get; set; }
        public string Type { get; set; }
        public string CompeCode { get; set; }
        public string BranchCode { get; set; }
        public string Number { get; set; }
        public string CheckDigit { get; set; }
        public string AccountID { get; set; }
        public string Subtype { get; set; }
        public string Currency { get; set; }
    }
}
