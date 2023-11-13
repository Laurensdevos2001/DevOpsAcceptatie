using Oogarts.Shared.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Appointments
{
    public abstract class AppointmentResult
    {
        public class Index
        {
            public IEnumerable<AppointmentDto.Index>? Appointments { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
