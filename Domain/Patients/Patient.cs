using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Patients
{
    public class Patient : Entity
    {
        private string firstname = default!;
        public string Firstname
        {
            get => firstname;
            set => firstname = Guard.Against.NullOrWhiteSpace(value, nameof(Firstname));
        }

        private string lastname = default!;
        public string Lastname
        {
            get => lastname;
            set => lastname = Guard.Against.NullOrWhiteSpace(value, nameof(Lastname));
        }

        private string email = default!;
        public string Email
        {
            get => email;
            set => email = Guard.Against.NullOrWhiteSpace(value, nameof(Email));
        }

        private string phonenumber = default!;
        public string Phonenumber
        {
            get => phonenumber;
            set => phonenumber = Guard.Against.NullOrWhiteSpace(value, nameof(Phonenumber));
        }

        private DateTime birthdate;

        public DateTime Birthdate
        {
            get => birthdate;
            set => birthdate = Guard.Against.Null(value, nameof(birthdate));
        }
        private Patient() { }
        public Patient(string firstname, string lastname, string email, string phonenumber, DateTime birthdate)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phonenumber = phonenumber;
            Birthdate = birthdate;
        }


    }
}
