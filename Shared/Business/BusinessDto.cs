using FluentValidation;
using Oogarts.Shared.OpeningHours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Oogarts.Shared.Business
{
    public class BusinessDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? City { get; set; }
        }
        public class Detail
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? City { get; set; }
            public string? PostalCode { get; set; }
            public string? Street { get; set; }
            public string? HouseNumber { get; set; }
            public string? Phone {  get; set; }

            public List<OpeningHourDto.Index?>? OpeningHours { get; set; }


        }
        public class Mutate
        {
            public string? Name { get; set; }
            public string? City { get; set; }
            public string? PostalCode { get; set; }
            public string? Street { get; set; }
            public string? HouseNumber { get; set; }
            public string? Phone { get; set; }
            public string? Logo { get; set; }
            public string? ContactMail { get; set; }

            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.Name).NotEmpty();
                    RuleFor(x => x.City).NotEmpty();
                    RuleFor(x => x.PostalCode).NotEmpty().MaximumLength(20);
                    RuleFor(x => x.Street).NotEmpty().MaximumLength(100);
                    RuleFor(x => x.HouseNumber).NotEmpty().MaximumLength(10);
                    RuleFor(x => x.Phone).NotEmpty().Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                    RuleFor(x => x.Logo).NotEmpty();
                    RuleFor(x => x.ContactMail).NotEmpty().EmailAddress();
                }
            }
        }
    }
}
