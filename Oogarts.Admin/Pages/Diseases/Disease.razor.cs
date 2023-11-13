using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Staffs;
using Oogarts.Shared.Diseases;

namespace Oogarts.Admin.Pages.Diseases
{
    public partial class Disease
    {
        private IEnumerable<DiseaseDto.Index>? diseases;
        private GridItemsProvider<DiseaseDto.Index>? diseasesProvider;
        private string? searchTerm;

        [Inject] public IDiseaseService diseaseService { get; set; } = default!;

        [Parameter, SupplyParameterFromQuery] public string? Search { get; set; }

        protected override async Task OnInitializedAsync()
        {
            diseasesProvider = async req =>
            {



                DiseaseRequest.Index request = new()
                {
                    Page = req.StartIndex,
                    PageSize = (int)(req.Count ?? 10),
                    Search = Search,
                    SortByAscending = req.SortByAscending ? req.SortByAscending : false,
                    SortByColumn = req.SortByColumn?.Title ?? "Id"

                };



                var response = await diseaseService.GetIndexAsync(request);
                return GridItemsProviderResult.From(
                                       items: response.Diseases?.ToList() ?? new List<DiseaseDto.Index>(),
                                                          totalItemCount: response.TotalAmount);

            };
        }

        private async Task RemoveDiseaseAsync(int Id)
        {
            await diseaseService.RemoveAsync(Id);
            diseases = diseases?.Where(x => x.Id != Id).ToList();
        }
    }
}
