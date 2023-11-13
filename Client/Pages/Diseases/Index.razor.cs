using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Diseases;
using Oogarts.Shared.Staffs;

namespace Oogarts.Client.Pages.Diseases
{
    public partial class Index
    {
        [Inject] public IDiseaseService diseaseService { get; set; } = default!;
        private IEnumerable<DiseaseDto.Index>? diseases;
        private IEnumerable<DiseaseDto.Index>? filteredDiseases;
        protected override async Task OnInitializedAsync()
        {
            DiseaseRequest.Index request = new()
            {
                Page = 0,
                PageSize = 100,
                Search = "",
                SortByAscending = true,
                SortByColumn = "Id"

            };

            

            var response = await diseaseService.GetIndexAsync(request);
            diseases = response.Diseases?.ToList() ?? new List<DiseaseDto.Index>();
            filteredDiseases = diseases;
        }
    }
}
