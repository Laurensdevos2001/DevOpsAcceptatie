using Microsoft.AspNetCore.Components;
using Oogarts.Admin.Pages.Team;
using Oogarts.Domain.Jobs;
using Oogarts.Shared.Diseases;
using Oogarts.Shared.Job;
using Oogarts.Shared.Staffs;
using System.Numerics;

namespace Oogarts.Admin.Pages.Diseases
{
    public partial class EditDisease
    {
        private DiseaseDto.Mutate disease = new();
        [Inject] public IDiseaseService diseaseService { get; set; } = default!;
        [Parameter] public int Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            DiseaseDto.Detail detail = await diseaseService.GetDetailAsync(Id);
            disease = new DiseaseDto.Mutate
            {
                AuthorId = detail.AuthorId ?? 0,
                Content = detail.Content,
                Name = detail.Name,
            };
        }
        private async Task EditDiseaseAsync()
        {
            try
            {
                await diseaseService.EditAsync(Id,disease);
                NavigationManager.NavigateTo("/disease");
            }
            catch (Exception ex)
            {
                await this.ToastObj.ShowAsync();
            }
        }
    }
}
