using Oogarts.Shared.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Staffs
{
    public abstract class StaffResult
    {
        public class Index
        { 
            public IEnumerable<StaffDto.Index>? Doctors { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
