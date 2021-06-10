using CDS.OpenBanking.Accounts.Domain.Entities.Accounts;
using CDS.OpenBanking.Accounts.Domain.Interfaces.Repository;
using CDS.OpenBanking.Accounts.Infra.OpenBankingResult;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDS.OpenBanking.Accounts.Infra.Mock
{
    public class AccountRepositoryMock : IAccountRepository
    {
        public async Task<ICollection<Account>> GetAccounts()
        {
            var json = @"
                        {
                          'data': [
                            {
                              'brandName': 'Organização A',
                              'companyCnpj': '21128159000166',
                              'type': 'CONTA_DEPOSITO_A_VISTA',
                              'compeCode': '001',
                              'branchCode': '6272',
                              'number': '94088392',
                              'checkDigit': '4',
                              'accountID': '92792126019929279212650822221989319252576'
                            }
                          ],
                          'links': {
                            'self': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'first': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'prev': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'next': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'last': 'https://api.banco.com.br/open-banking/api/v1/resource'
                          },
                          'meta': {
                            'totalRecords': 1,
                            'totalPages': 1,
                            'requestDateTime': '2021-05-21T08:30:00Z'
                          }
                        }";

            AccountsResult result = JsonConvert.DeserializeObject<AccountsResult>(json);

            return await Task.Run(() => { return result.Data; });
        }

        public async Task<Account> GetAccount(string accountId)
        {
            var json = @"
                        {
                          'data': {
                            'compeCode': '001',
                            'branchCode': '6272',
                            'number': '24550245',
                            'checkDigit': '4',
                            'type': 'CONTA_DEPOSITO_A_VISTA',
                            'subtype': 'INDIVIDUAL',
                            'currency': 'BRL'
                          },
                          'links': {
                            'self': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'first': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'prev': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'next': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'last': 'https://api.banco.com.br/open-banking/api/v1/resource'
                          },
                          'meta': {
                            'totalRecords': 1,
                            'totalPages': 1,
                            'requestDateTime': '2021-05-21T08:30:00Z'
                          }
                        }";

            AccountResult result = JsonConvert.DeserializeObject<AccountResult>(json);

            return await Task.Run(() => { return result.Data; });
        }

        public async Task<Balance> GetBalances(string accountId)
        {
            var json = @"
                        {
                            'data': {
                            'availableAmount': 100000.04,
                            'availableAmountCurrency': 'BRL',
                            'blockedAmount': 99.9999,
                            'blockedAmountCurrency': 'BRL',
                            'automaticallyInvestedAmount': 2566449494219,
                            'automaticallyInvestedAmountCurrency': 'BRL'
                            },
                            'links': {
                            'self': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'first': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'prev': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'next': 'https://api.banco.com.br/open-banking/api/v1/resource',
                            'last': 'https://api.banco.com.br/open-banking/api/v1/resource'
                            },
                            'meta': {
                            'totalRecords': 1,
                            'totalPages': 1,
                            'requestDateTime': '2021-05-21T08:30:00Z'
                            }
                        }
";

            BalanceResult result = JsonConvert.DeserializeObject<BalanceResult>(json);

            return await Task.Run(() => { return result.Data; });
        }
    }
}