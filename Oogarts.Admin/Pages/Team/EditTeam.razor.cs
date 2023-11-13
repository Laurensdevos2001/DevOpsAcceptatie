using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using Oogarts.Shared.Job;
using Oogarts.Shared.Staffs;
using Syncfusion.Blazor.Charts.Chart.Internal;
using Syncfusion.Blazor.DropDowns;
using System.IO;
using System.Net;
using System.Text;

namespace Oogarts.Admin.Pages.Team
{
    public partial class EditTeam
    {
        private StaffDto.Mutate doctor = new();
        private IEnumerable<JobDto.Index> jobs;
        [Parameter] public int Id { get; set; }
        [Inject] public IJobService JobService { get; set; } = default!;
        private HttpClient Http { get; set; } = new();

        [Parameter] public EventCallback OnCustomerEdited { get; set; }
        [Inject] public IStaffService DoctorService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            StaffDto.Detail detail = await DoctorService.GetDetailAsync(Id);
            Console.WriteLine(detail.Job.Id);
            doctor = new StaffDto.Mutate
            {
                Email = detail.Email,
                FirstName = detail.FirstName,
                LastName = detail.LastName,
                PhoneNumber = detail.PhoneNumber,
                Specialization = detail.Specialization,
                JobId = detail.Job?.Id,
            };
            if(detail.Image.IsNullOrEmpty())
            {
                base64 = "/stock.png";
            }
            else
            {
                Byte[] a = await DoctorService.GetFileAsync(detail.Image);

                // convert byte[] to Base64 String

                base64 = "data:image/png;base64," + Convert.ToBase64String(a);

            }

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
        }

        private async Task EditDoctorAsync()
        {
            await DoctorService.EditAsync(Id, doctor);
            await OnCustomerEdited.InvokeAsync();
            NavigationManager.NavigateTo("/team");
        }
    }
}
