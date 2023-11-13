using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Oogarts.Shared.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Oogarts.Client.Pages.Diseases
{
    public partial class Disease
    {
            private DiseaseDto.Detail disease;
        [Parameter] public int Id { get; set; }
        [Inject] public IDiseaseService diseaseService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            disease = await diseaseService.GetDetailAsync(Id);
        }
    }
    }
