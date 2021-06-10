using CDS.OpenBanking.Accounts.Domain.Interfaces.Service;
using CDS.OpenBanking.Accounts.Infra.Mock;
using CDS.OpenBanking.Accounts.Service.Mock;
using System;
using System.Threading.Tasks;

namespace dev.hitalo.carteiradossonhos
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountService accountService = new AccountServiceMock(new AccountRepositoryMock());

            var result = Task.Run(() => accountService.Getaccounts()).Result;

            Console.WriteLine("Hello World!");
        }
    }
}
