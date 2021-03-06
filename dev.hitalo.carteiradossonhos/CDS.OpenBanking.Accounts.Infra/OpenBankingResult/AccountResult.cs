using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;

namespace CDS.OpenBanking.Accounts.Infra.OpenBankingResult
{
    public class AccountResult
    {
        public Account Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }
    }
}