using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Patients
{
    public interface IPatientService
    {
        Task<PatientDto.Detail> GetDetailAsync(int patientId);
        Task<PatientResult.Index> GetIndexAsync(PatientRequest.Index request);
        Task<int> CreateAsync(PatientDto.Mutate model);
        Task EditAsync(int patientId, PatientDto.Mutate model);
        Task RemoveAsync(int patiendId);
    }
}
