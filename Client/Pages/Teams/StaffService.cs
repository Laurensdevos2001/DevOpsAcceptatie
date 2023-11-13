using Oogarts.Admin.Extensions;
using Oogarts.Shared.Staffs;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Oogarts.Admin.Pages.Team
{
    public class StaffService : IStaffService
    {
        private readonly HttpClient client;
        private const string endpoint = "/Staff";
        public StaffService(HttpClient client)
        {
               this.client = client;
        }

        public async Task<StaffResult.Index> GetIndexAsync(StaffRequest.Index request)
        {
            var response = await client.GetFromJsonAsync<StaffResult.Index>($"{endpoint}?{request.AsQueryString()}");
            return response!;
        }

        public async Task<StaffDto.Detail> GetDetailAsync(int doctorId)
        {
            var response = await client.GetFromJsonAsync<StaffDto.Detail>($"{endpoint}/{doctorId}");
            return response!;
        }

        public async Task<int> CreateAsync(StaffDto.Mutate model)
        {
            var response = await client.PostAsJsonAsync(endpoint, model);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task EditAsync(int doctorId, StaffDto.Mutate model)
        {
            await client.PutAsJsonAsync($"{endpoint}/{doctorId}", model);
        }

        public async Task RemoveAsync(int doctorId)
        {
            await client.DeleteAsync($"{endpoint}/{doctorId}");
        }
        public async Task<Byte[]> GetFileAsync(string fileName)
        {
            // Construct the endpoint to retrieve the file
            var fileEndpoint = $"/Files{fileName}";

            // Send an HTTP GET request to retrieve the file
            var response = await client.GetAsync(fileEndpoint);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Return the file content as a base64-encoded string
                return await response.Content.ReadAsByteArrayAsync();
            }
            else
            {
                // Handle the case when the file retrieval was not successful
                return null; // or throw an exception, log an error, etc.
            }
        }

    }
}
