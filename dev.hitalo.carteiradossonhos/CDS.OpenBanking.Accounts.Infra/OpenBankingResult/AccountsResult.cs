using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;
using System.Collections.Generic;

namespace CDS.OpenBanking.Accounts.Infra.OpenBankingResult
{
    public class AccountsResult
    {
        public ICollection<Account> Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }
    }
}