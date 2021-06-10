using CDS.OpenBanking.Accounts.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Service
{
    public interface IAccountService
    {
        Task<ICollection<Account>> Getaccounts();
    }
}