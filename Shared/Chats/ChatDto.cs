using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Chats
{
    public class ChatDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string Message { get; set; }
        }
        public class Detail
        {
            public int Id { get; set; }
            public string Message { get; set; }
            public ChatDto.Index? Previous { get; set; }
            public List<ChatDto.Index>? Responses { get; set; }
        }
        public class Mutate
        {
            public int Id { get; set; }
            public string Message { get; set; }
            public ChatDto.Index? Previous { get; set; }
            public List<ChatDto.Index>? Responses { get; set; }

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.Message).NotEmpty();
                }
            }
        }
    }
}
