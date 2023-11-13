using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Diseases
{
    public interface IDiseaseService
    {
        Task<DiseaseDto.Detail> GetDetailAsync(int diseaseId);
        Task<DiseaseResult.Index> GetIndexAsync(DiseaseRequest.Index request);
        Task<int> CreateAsync(DiseaseDto.Mutate model);
        Task EditAsync(int diseaseId, DiseaseDto.Mutate model);
        Task RemoveAsync(int diseaseId);
    }
}
