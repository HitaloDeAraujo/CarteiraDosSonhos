using CDS.OpenBanking.Accounts.Domain.Entities.Personal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Repository
{
    public interface IPersonalRepository
    {
        Task<ICollection<Identification>> GetIdentifications();
    }
}