using Oogarts.Shared.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Diseases
{
    public abstract class DiseaseResult
    {
        public class Index
        {
            public IEnumerable<DiseaseDto.Index>? Diseases { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
