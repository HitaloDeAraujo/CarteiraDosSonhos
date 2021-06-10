using CDS.OpenBanking.Accounts.Domain.Entities;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Repository;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Service.Mock
{
    public class AccountServiceMock : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountServiceMock(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ICollection<Account>> Getaccounts()
        {
            var result = await _accountRepository.GetAccounts();

            return result;
        }
    }
}
