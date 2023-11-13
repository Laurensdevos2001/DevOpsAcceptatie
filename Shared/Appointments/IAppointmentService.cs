using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Appointments
{
    public interface IAppointmentService
    {
        Task<AppointmentDto.Detail> GetDetailAsync(int appointmentId);
        Task<AppointmentResult.Index> GetIndexAsync(AppointmentRequest.Index request);
        Task<int> CreateAsync(AppointmentDto.Mutate model);
        Task EditAsync(int appointmentId, AppointmentDto.Mutate model);
        Task RemoveAsync(int postId);
    }
}
