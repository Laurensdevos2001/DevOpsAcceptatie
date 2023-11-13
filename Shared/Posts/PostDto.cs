using FluentValidation;
using Oogarts.Shared.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Posts
{
    public class PostDto
    {
        public class Index
        {
            public int Id { get; set; }
            public AccountDto.Index Author { get; set; }
            public string? Title { get; set; }

            public string? Introduction { get; set; }
            public string? Image { get; set; }

        }

        public class Detail
        {
            public int Id { get; set; }
            public AccountDto.Index Author { get; set; }

            public string? Content { get; set; }
            public string? Title { get; set; }

            public string? Introduction { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public string? Image { get; set; }
        }

        public class Mutate
        {
            public int AuthorId { get; set; }
            public string? Content { get; set; }
            public string? Title { get; set; }

            public string? Introduction { get; set; }
            public string? Image { get; set; }
        }
        public class Validator : AbstractValidator<Mutate>
        {
            public Validator()
            {
                RuleFor(x => x.AuthorId).NotEmpty();
                RuleFor(x => x.Content).NotEmpty();
                RuleFor(x => x.Title).NotEmpty();
                RuleFor(x => x.Introduction).NotEmpty();

            }
        }
    }
}
