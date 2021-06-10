using CDS.OpenBanking.Accounts.Domain.Interfaces.Service;
using CDS.OpenBanking.Accounts.Infra.Mock;
using CDS.OpenBanking.Accounts.Service;
using CDS.OpenBanking.Personal.Infra.Mock;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace dev.hitalo.carteiradossonhos
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountService accountService = new AccountService(new AccountRepositoryMock());
            IPersonalService personalService = new PersonalService(new PersonalRepositoryMock());

            var accounts = Task.Run(() => accountService.GetAccounts()).Result;

            var accountID = accounts.ToList().First().AccountID;

            var account = Task.Run(() => accountService.GetAccount(accountID)).Result;

            var balances = Task.Run(() => accountService.GetBalances(accountID)).Result;

            var Identifications = Task.Run(() => personalService.GetIdentifications()).Result;

            Console.WriteLine("Hello World!");
        }
    }
}
