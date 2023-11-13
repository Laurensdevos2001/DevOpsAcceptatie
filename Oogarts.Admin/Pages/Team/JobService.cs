using Oogarts.Admin.Extensions;
using Oogarts.Shared.Job;
using Oogarts.Shared.Staffs;
using System.Net.Http.Json;

namespace Oogarts.Admin.Pages.Team
{
    public class JobService : IJobService
    {
        private readonly HttpClient client;
        private const string endpoint = "/Job";
        public JobService(HttpClient client)
        {
               this.client = client;
        }

        public async Task<JobResult.Index> GetIndexAsync(JobRequest.Index request)
        {
            var response = await client.GetFromJsonAsync<JobResult.Index>($"{endpoint}?{request.AsQueryString()}");
            return response!;
        }

        public async Task<JobDto.Detail> GetDetailAsync(int doctorId)
        {
            var response = await client.GetFromJsonAsync<JobDto.Detail>($"{endpoint}/{doctorId}");
            return response!;
        }

        public async Task<int> CreateAsync(JobDto.Mutate model)
        {
            var response = await client.PostAsJsonAsync(endpoint, model);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task EditAsync(int doctorId, JobDto.Mutate model)
        {
            await client.PutAsJsonAsync($"{endpoint}/{doctorId}", model);
        }

        public async Task RemoveAsync(int doctorId)
        {
            await client.DeleteAsync($"{endpoint}/{doctorId}");
        }

    }
}
