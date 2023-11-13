using Oogarts.Admin.Extensions;
using Oogarts.Shared.Common;
using Oogarts.Shared.Diseases;
using System.Net.Http.Json;

namespace Oogarts.Admin.Pages.Diseases
{
    public class DiseaseService : IDiseaseService
    {
        private readonly HttpClient client;
        private const string endpoint = "/Disease";
        public DiseaseService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<int> CreateAsync(DiseaseDto.Mutate model)
        {
            throw new NotImplementedException();
        }

        public async Task EditAsync(int diseaseId, DiseaseDto.Mutate model)
        {
            await client.PutAsJsonAsync($"{endpoint}/{diseaseId}", model);
        }

        public async Task<DiseaseDto.Detail> GetDetailAsync(int diseaseId)
        {
            var response = await client.GetFromJsonAsync<DiseaseDto.Detail>($"{endpoint}/{diseaseId}");
            return response!;
        }

        public async Task<DiseaseResult.Index> GetIndexAsync(Request.Index request)
        {
            var response = await client.GetFromJsonAsync<DiseaseResult.Index>($"{endpoint}?{request.AsQueryString()}");
            return response!;
        }

        public async Task RemoveAsync(int diseaseId)
        {
            await client.DeleteAsync($"{endpoint}/{diseaseId}");
        }
    }
}
