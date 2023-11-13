using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using Oogarts.Domain.OpeningHours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Businesses
{
    public class Business : Entity
    {
        private string name = default!;
        public string Name
        {
            get => name;
            set => name = Guard.Against.NullOrWhiteSpace(value, nameof(Name));
        }

        private string contactEmail = default!;
        public string ContactEmail
        {
            get => contactEmail;
            set => contactEmail = Guard.Against.NullOrWhiteSpace(value, nameof(ContactEmail));
        }

        private string city = default!;
        public string City
        {
            get => city;
            set => city = Guard.Against.NullOrWhiteSpace(value, nameof(City));
        }

        private string postalCode = default!;
        public string PostalCode
        {
            get => postalCode;
            set => postalCode = Guard.Against.NullOrWhiteSpace(value, nameof(PostalCode));
        }

        private string street = default!;
        public string Street
        {
            get => street;
            set => street = Guard.Against.NullOrWhiteSpace(value, nameof(Street));
        }

        private string houseNumber = default!;
        public string HouseNumber
        {
            get => houseNumber;
            set => houseNumber = Guard.Against.NullOrWhiteSpace(value, nameof(HouseNumber));
        }

        private string phone = default!;
        public string Phone
        {
            get => phone;
            set => phone = Guard.Against.NullOrWhiteSpace(value, nameof(Phone));
        }

        private List<OpeningHour> openingHours = default!;

        public List<OpeningHour> OpeningHours
        {
            get => openingHours;
            set => openingHours = Guard.Against.Null(value, nameof(OpeningHours));
        }

        private string logo = default!;
        public string Logo
        {
            get => logo;
            set => logo = Guard.Against.NullOrWhiteSpace(value, nameof(Logo));
        }
        private Business() { }

        public Business(string name, string city, string postalCode, string street, string houseNumber, string phone, string contactEmail, string logo)
        {
            Name = name;
            City = city;
            PostalCode = postalCode;
            Street = street;
            HouseNumber = houseNumber;
            Phone = phone;
            ContactEmail = contactEmail;
            Logo = logo;
        }
    }
}
