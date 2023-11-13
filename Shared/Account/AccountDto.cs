using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Account
{
    public class AccountDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string? UserName { get; set; }

           // public string? Password { get; set; }

            public int staffId { get; set; }
        }

        public class Detail
        {
            public int Id { get; set; }
            public string? UserName { get; set; }
            public string? Password { get; set; }
            public int staffId { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }

        public class Mutate
        {
            public string? UserName { get; set; }
            public string? Password { get; set; }

            public int staffId { get; set; }
        }
        public class Validator : AbstractValidator<Mutate>
        {
            public Validator()
            {
                RuleFor(x => x.UserName).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
                RuleFor(RuleFor => RuleFor.staffId).NotEmpty();
            }
        }
    }
}
