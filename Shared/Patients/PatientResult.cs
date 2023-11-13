using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Patients
{
    public abstract class PatientResult
    {
        public class Index
        {
            public IEnumerable<PatientDto.Index>? Patients { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
