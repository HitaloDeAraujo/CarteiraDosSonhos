using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Repository
{
    public interface IAccountRepository
    {
        Task<ICollection<Account>> GetAccounts();
        Task<Account> GetAccount(string accountId);
        Task<Balance> GetBalances(string accountId);
    }
}