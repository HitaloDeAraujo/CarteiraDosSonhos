using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;

namespace CDS.OpenBanking.Accounts.Infra.OpenBankingResult
{
    public class BalanceResult
    {
        public Balance Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }
    }
}
