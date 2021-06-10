using CDS.OpenBanking.Accounts.Domain.Entities.Personal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Domain.Interfaces.Service
{
    public interface IPersonalService
    {
        Task<ICollection<Identification>> GetIdentifications();
    }
}