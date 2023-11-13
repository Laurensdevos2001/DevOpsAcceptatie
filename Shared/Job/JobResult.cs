using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Job
{
    public abstract class JobResult
    {
        public class Index
        {
            public IEnumerable<JobDto.Index>? Jobs { get; set; }
            public int TotalAmount { get; set; }

        }
    }
}
