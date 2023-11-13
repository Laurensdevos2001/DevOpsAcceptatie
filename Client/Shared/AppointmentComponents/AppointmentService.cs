using Oogarts.Shared.Appointments;
using Oogarts.Shared.Common;
using System.Net.Http.Json;

namespace Oogarts.Client.Shared.AppointmentComponents
{
    public class AppointmentService : IAppointmentService
    {
        private readonly HttpClient _httpClient;
        private const string _endpoints = "/Appointment";


        public async Task<int> CreateAsync(AppointmentDto.Mutate model)
        {
            var response = await _httpClient.PostAsJsonAsync(_endpoints, model);
            return await response.Content.ReadFromJsonAsync<int>();
        }


        // om errors te vermijden
        public Task<AppointmentDto.Detail> GetDetailAsync(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Task<AppointmentResult.Index> GetIndexAsync(Request.Index request)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int appointmentId, AppointmentDto.Mutate model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
