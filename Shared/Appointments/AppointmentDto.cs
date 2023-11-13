using FluentValidation;
using Oogarts.Shared.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oogarts.Shared.Staffs;

namespace Oogarts.Shared.Appointments
{
    public class AppointmentDto
    {
        public class Index
        {
            public int Id { get; set; }
            public PatientDto.Index? Patient { get; set; }
            public StaffDto.Index? Staff { get; set; }
            public DateTime DateTimeAppointment { get; set; }
            public string Description { get; set; } = default!;
            public string Status { get; set; } = default!;
        }

        public class Detail
        {
            public int Id { get; set; }
            public PatientDto.Index? Patient { get; set; }
            public StaffDto.Index? Staff { get; set; }
            public DateTime DateTimeAppointment { get; set; }
            public string Description { get; set; } = default!;
            public string Status { get; set; } = default!;

            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }

        public class Mutate
        {
            public int? PatientId { get; set; }
            public int? StaffId { get; set; }
            public DateTime DateTimeAppointment { get; set; }
            public string? Description { get; set; }
            public string Status { get; set; } = default!;

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.PatientId).NotEmpty();
                    RuleFor(x => x.StaffId).NotEmpty();
                    RuleFor(x => x.DateTimeAppointment).NotEmpty();
                    RuleFor(x => x.Description).NotEmpty().MaximumLength(1_000);
                    RuleFor(x => x.Status).NotEmpty().MaximumLength(100);
                }
            }
        }
    }
}
