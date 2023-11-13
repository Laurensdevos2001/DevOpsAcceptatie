using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.OpeningHours
{
    public abstract class OpeningHourResult
    {

        public class Index
        {
            public IEnumerable<OpeningHourDto.Index>? OpeningHours { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
