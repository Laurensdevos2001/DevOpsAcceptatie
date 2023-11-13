using Oogarts.Shared.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Account
{
    public abstract class AccountResult
    {
        public class Index
        {
            public IEnumerable<AccountDto.Index>? Accounts { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
