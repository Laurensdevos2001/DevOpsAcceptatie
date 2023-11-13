using Oogarts.Shared.Common;
using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.OpeningHours
{
    public interface IOpeningHourService
    {
        Task<OpeningHourDto.Detail> GetDetailAsync(int doctorId);
        Task<OpeningHourResult.Index> GetIndexAsync(OpeningHourRequest.Index request);
        Task<int> CreateAsync(OpeningHourDto.Mutate model);
        Task EditAsync(int openingHourId, OpeningHourDto.Mutate model);
        Task RemoveAsync(int openingHourId);
    }
}
