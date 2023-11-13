using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Business
{
    public interface IBusinessService
    {
        Task<BusinessDto.Detail> GetDetailAsync(int businessId);
        Task<BusinessResult.Index> GetIndexAsync(BusinessRequest.Index request);
        Task<int> CreateAsync(BusinessDto.Mutate model);
        Task EditAsync(int businessId, BusinessDto.Mutate model);
        Task RemoveAsync(int businessId);
    }
}
