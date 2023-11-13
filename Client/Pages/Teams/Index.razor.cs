using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Staffs;
using System.Buffers.Text;

namespace Oogarts.Client.Pages.Teams
{
    public partial class Index
    {
        [Inject] public IStaffService staffService { get; set; } = default!;
        private IEnumerable<StaffDto.Index>? staffs;
        private Dictionary<string, StaffDto.Index[]>? team = new();
        protected override async Task OnInitializedAsync()
        {
            StaffRequest.Index request = new()
            {
                Page = 0,
                PageSize = 100,
                Search = "",
                SortByAscending = true,
                SortByColumn = "Id"

            };



            var response = await staffService.GetIndexAsync(request);
            staffs = response.Staffs?.ToList() ?? new List<StaffDto.Index>();

            foreach (var staff in staffs)
            {
                /*
                  if(detail.Image.IsNullOrEmpty())
           {
               base64 = "/stock.png";
           }
           else
           {
               Byte[] a = await DoctorService.GetFileAsync(detail.Image);

               // convert byte[] to Base64 String

               base64 = "data:image/png;base64," + Convert.ToBase64String(a);

           }*/

                Byte[] a = await staffService.GetFileAsync(staff.Image);   

                Console.WriteLine(a);

                // convert byte[] to Base64 String

                staff.Image = "data:image/png;base64," + Convert.ToBase64String(a);
                if(team.TryGetValue(staff.Job.Name, out var staffsInTeam))
                {
                    team[staff.Job.Name] = staffsInTeam.Append(staff).ToArray();
                }
                else
                {
                    team.Add(staff.Job.Name, new StaffDto.Index[] { staff });
                }
            }
        }
    }
}
