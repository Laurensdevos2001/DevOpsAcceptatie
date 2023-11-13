using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Patients
{
    public  class PatientDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Email { get; set; }
        }

        public class Detail
        {
            public int Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Email { get; set; }
            public DateTime? Birthdate { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }

        public class Mutate
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string Email { get; set; } = default!;
            public string PhoneNumber { get; set; } = default!;
            public DateTime Birthdate { get; set; } = default!;

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.FirstName).NotEmpty();
                    RuleFor(x => x.LastName).NotEmpty();
                    RuleFor(x => x.Email).NotEmpty();
                    RuleFor(x => x.PhoneNumber).NotEmpty();
                    RuleFor(x => x.Birthdate).NotEmpty();
                }
            }
            
        }
    }
}
