using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Job
{
    public interface IJobService
    {
        Task<JobDto.Detail> GetDetailAsync(int doctorId);
        Task<JobResult.Index> GetIndexAsync(JobRequest.Index request);

        Task<int> CreateAsync(JobDto.Mutate model);

        Task EditAsync(int jobId, JobDto.Mutate model);

        Task RemoveAsync(int jobId);
    }
}
