using CDS.OpenBanking.Accounts.Domain.Entities;
using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Service
{
    public interface IAccountService
    {
        Task<ICollection<Account>> GetAccounts();
        Task<Account> GetAccount(string accountId);
        Task<Balance> GetBalances(string accountId);
    }
}