using Oogarts.Shared.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Business
{
    public abstract class BusinessResult
    {
        public class Index
        {
            public IEnumerable<BusinessDto.Index>? Businesses { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
