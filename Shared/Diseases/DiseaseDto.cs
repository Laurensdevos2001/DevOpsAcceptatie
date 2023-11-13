using FluentValidation;
using Oogarts.Shared.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Diseases
{
    public class DiseaseDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int? AuthorId { get; set; }

        }

        public class Detail
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int? AuthorId { get; set; }
            public string? Content { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }

        public class Mutate
        {
            public string? Name { get; set; }
            public int AuthorId { get; set; }
            public string? Content { get; set; }

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.Name).NotEmpty();
                    RuleFor(x => x.AuthorId).NotEmpty();
                    RuleFor(x => x.Content).NotEmpty();
                }
            }
        }
    }
}
