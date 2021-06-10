using CDS.OpenBanking.Accounts.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Repository
{
    public interface IAccountRepository
    {
        Task<ICollection<Account>> GetAccounts();
    }
}
