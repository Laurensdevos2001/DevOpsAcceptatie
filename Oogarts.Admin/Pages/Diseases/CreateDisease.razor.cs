using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Diseases;

namespace Oogarts.Admin.Pages.Diseases
{
    public partial class CreateDisease
    {
        private DiseaseDto.Mutate disease = new();
        [Inject] public IDiseaseService diseaseService { get; set; } = default!;

        private async Task CreateDiseaseAsync()
        {
            try
            {
                await diseaseService.CreateAsync(disease);
                NavigationManager.NavigateTo("/disease");
            }
            catch (Exception ex)
            {
                await this.ToastObj.ShowAsync();
            }
        }
    }
}
