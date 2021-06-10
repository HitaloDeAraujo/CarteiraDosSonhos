using CDS.OpenBanking.Accounts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Infra.OpenBankingResult
{
    public class AccountResult
    {
        public ICollection<Account> Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }

        public static implicit operator Task<object>(AccountResult v)
        {
            throw new NotImplementedException();
        }
    }
}