using CDS.OpenBanking.Accounts.Domain.Entities.Personal;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Repository;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Service
{
    public class PersonalService : IPersonalService
    {
        private IPersonalRepository _personalRepository;

        public PersonalService(IPersonalRepository personalRepository)
        {
            _personalRepository = personalRepository;
        }

        public async Task<ICollection<Identification>> GetIdentifications()
        {
            var result = await _personalRepository.GetIdentifications();

            return result;
        }
    }
}
