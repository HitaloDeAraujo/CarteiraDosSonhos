using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Repository;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ICollection<Account>> GetAccounts()
        {
            var result = await _accountRepository.GetAccounts();

            return result;
        }

        public async Task<Account> GetAccount(string accountId)
        {
            var result = await _accountRepository.GetAccount(accountId);

            return result;
        }

        public async Task<Balance> GetBalances(string accountId)
        {
            var result = await _accountRepository.GetBalances(accountId);

            return result;
        }
    }
}
