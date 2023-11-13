using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Job;
using Oogarts.Shared.Staffs;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.DropDowns;
using System.Diagnostics.Metrics;

namespace Oogarts.Admin.Pages.Team
{
    public partial class CreateTeam
    {
        public Query Query = new Query();
        private StaffDto.Mutate doctor = new();
        private JobDto.Mutate job = new();
        [Parameter] public EventCallback OnCustomerCreated { get; set; }
        [Inject] public IStaffService staffService { get; set; } = default!;
        [Inject] public IJobService JobService { get; set; } = default!;
        private IEnumerable<JobDto.Index> jobs;

        protected override async Task OnInitializedAsync()
        {
            doctor.FirstName = "";
            doctor.Curriculem_Vitea = "";
            doctor.Image = "";
            doctor.JobId = null;
            doctor.Description = "test";
            JobRequest.Index request = new()
            {
                Page = 1,
                PageSize = 100,
                Search = null,
                SortByAscending = true,
                SortByColumn = "Id"
            };
            var response = await JobService.GetIndexAsync(request);
            jobs = response.Jobs?.ToList() ?? new List<JobDto.Index>();
            StateHasChanged();
        }

        private async Task CreateDoctorAsync()
        {
            try
            {
                await staffService.CreateAsync(doctor);
                await OnCustomerCreated.InvokeAsync();
                NavigationManager.NavigateTo("/team");
            }catch (Exception ex)
            {
                await this.ToastObj.ShowAsync();
            }
        }


        private async Task CreateJobAsync()
        {
            await JobService.CreateAsync(job);
            await OnCustomerCreated.InvokeAsync();
            JobRequest.Index request = new()
            {
                Page = 1,
                PageSize = 100,
                Search = null,
                SortByAscending = true,
                SortByColumn = "Id"
            };
            var response = await JobService.GetIndexAsync(request);
            jobs = response.Jobs?.ToList() ?? new List<JobDto.Index>();
            this.IsVisible = false;
            StateHasChanged();
        }
    }
}
