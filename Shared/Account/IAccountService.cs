using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Account
{
    public interface IAccountService
    {
        Task<AccountDto.Detail> GetDetailAsync(int accountId);
        Task<AccountResult.Index> GetIndexAsync(AccountRequest.Index request);
        Task<int> CreateAsync(AccountDto.Mutate model);
        Task EditAsync(int accountId, AccountDto.Mutate model);
    }
}
