using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Job
{
    public class JobDto
    {
        
        public class Index
        {
            public int Id { get; set;}
            
            public string? Name { get; set; }
            
        }

        public class Detail
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            
        }

        public class Mutate
        {
            public string? Name { get; set; }

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.Name).NotEmpty();
                }
            }

        }
    }
}
