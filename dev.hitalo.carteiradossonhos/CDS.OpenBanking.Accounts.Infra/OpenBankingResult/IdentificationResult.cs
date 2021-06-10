using CDS.OpenBanking.Accounts.Domain.Entities.Personal;
using System.Collections.Generic;

namespace CDS.OpenBanking.Accounts.Infra.OpenBankingResult
{
    public class IdentificationResult
    {
        public ICollection<Identification> Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }
    }
}