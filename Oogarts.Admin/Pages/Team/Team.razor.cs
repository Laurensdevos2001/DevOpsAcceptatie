using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Oogarts.Domain.Staffs;
using Oogarts.Shared.Staffs;

namespace Oogarts.Admin.Pages.Team
{
    public partial class Team
    {
        private IEnumerable<StaffDto.Index>? doctors;
        private GridItemsProvider<StaffDto.Index>? doctorsProvider;
        private string? searchTerm;

        [Inject] public IStaffService staffService { get; set; } = default!;

        [Parameter, SupplyParameterFromQuery] public string? Search { get; set; }

        protected override async Task OnInitializedAsync()
        {
            doctorsProvider = async req =>
            {



                StaffRequest.Index request = new()
                {
                    Page = req.StartIndex,
                    PageSize = (int) (req.Count ?? 10),
                    Search = Search,
                    SortByAscending = req.SortByAscending ? req.SortByAscending : false,
                    SortByColumn = req.SortByColumn?.Title ?? "Id"

                };



                var response = await staffService.GetIndexAsync(request);
                return GridItemsProviderResult.From(
                                       items: response.Staffs?.ToList() ?? new List<StaffDto.Index>(),
                                                          totalItemCount: response.TotalAmount);

            };
        }

        private async Task RemoveDoctorAsync(int Id)
        {
            await staffService.RemoveAsync(Id);
            doctors = doctors?.Where(x => x.Id != Id).ToList();
        }

    }
}
