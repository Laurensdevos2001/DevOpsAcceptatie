using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Appointments;
using Oogarts.Shared.Staffs;

namespace Oogarts.Client.Pages.Appointments
{
    public partial class Index
    {
        private AppointmentDto.Mutate _appointment = new();

        [Inject]
        public IAppointmentService appointmentService { get; set; }

        [Inject]
        public IStaffService staffService { get; set; }

        public IEnumerable<Doctor> doctors { get; set; } = new List<Doctor>();
        public class Doctor
        {
            public string? FullName { get; set; }
            public int Id { get; set; }
            // Add more properties and methods as needed
        }
        protected override async Task OnInitializedAsync()
        {
            StaffRequest.Index request = new()
            {
                Page = 0,
                PageSize = 100,
                Search = "",
                SortByAscending = false,
                SortByColumn = "Id"
            };
            var result = await staffService.GetIndexAsync(request);

            List<Doctor> doctorList = new List<Doctor>();

            foreach (var item in result.Staffs)
            {
                if (item.Job.Id == 1)
                {
                    Doctor d = new()
                    {
                        FullName = item.FirstName + " " + item.LastName,
                        Id = item.Id
                    };
                    Console.WriteLine(d.FullName);
                    doctorList.Add(d);
                }
            }

            doctors = doctorList;
            StateHasChanged();
        }



        private async Task _createAppointment()
        {
            await appointmentService.CreateAsync(_appointment);

        }
    }
}
