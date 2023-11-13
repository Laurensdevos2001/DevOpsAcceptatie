using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.OpeningHours
{
    public class OpeningHourDto
    {
        public class Index
        {

            public int Id { get; set; }
            
            public int DayOfWeek { get; set; }
            
            public TimeOnly Opening_Time { get; set; }
            
            public TimeOnly Closing_Time { get; set; }
        }

        public class Detail
        {

            public int Id { get; set; }

            public int DayOfWeek { get; set; }

            public TimeOnly Opening_Time { get; set; }

            public TimeOnly Closing_Time { get; set; }
        }

        public class Mutate
        {

            public int Id { get; set; }

            public int DayOfWeek { get; set; }

            public TimeOnly Opening_Time { get; set; }

            public TimeOnly Closing_Time { get; set; }
            
            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.Id).NotEmpty();
                    RuleFor(x => x.DayOfWeek).NotEmpty();
                    RuleFor(x => x.Opening_Time).NotEmpty();
                    RuleFor(x => x.Closing_Time).NotEmpty();
                    
                }
            }
        }
    }
}
