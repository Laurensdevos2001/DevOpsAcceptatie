using Oogarts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;

namespace Oogarts.Domain.Jobs
{
    public class Job : Entity
    {
        
        private Job() { }
        private string name = default!;
        public string Name
        {
            get => name;
            set => name = Guard.Against.NullOrWhiteSpace(value, nameof(Name));
        }
        public Job(string name)
        {
            Name = name;
        }
    }
}
