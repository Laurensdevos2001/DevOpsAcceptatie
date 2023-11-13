using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using Oogarts.Domain.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Staffs
{
    public class Staff : Entity
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

        private int jobid = default!;
        public int JobId
        {
            get => jobid;
            set => jobid = Guard.Against.Null(value, nameof(Job));
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

        private string specialization = default!;
        public string Specialization
        {
            get => specialization;
            set => specialization = Guard.Against.NullOrWhiteSpace(value, nameof(Specialization));
        }

        private string curriculem_vitae = default!;
        
        public string CurriculemVitae
        {
            get => curriculem_vitae;
            set => curriculem_vitae = Guard.Against.Null(value, nameof(curriculem_vitae));
        }

        private string image = default!;
        public string Image
        {
            get => image;
            set => image = Guard.Against.Null(value, nameof(image));
        }

        private string description = default!;
        
        public string Description
        {
            get => description;
            set => description = Guard.Against.Null(value, nameof(description));
        }
        private Staff() { }
        public Staff(string firstname, string lastname, string email, string phonenumber, string specialization, int jobId, string curriculumVitae, string image, string description)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phonenumber = phonenumber;
            Specialization = specialization;
            JobId = jobId;
            CurriculemVitae = curriculumVitae;
            Image = image;
            Description = description;
        }
    }
}
