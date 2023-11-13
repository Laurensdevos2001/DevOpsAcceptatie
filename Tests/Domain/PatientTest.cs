using Oogarts.Domain.Staffs;
using Oogarts.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain
{
    public class PatientTest
    {
        DateTime dateTime = new DateTime(1995, 1, 1);

        [Fact]
        public void NewPatient_CreatedCorrectly()
        {
            Patient patient = new Patient("TestFirstName", "TestLastName", "test@testmail.com", "0470000000", dateTime);
            Assert.NotNull(patient);
            Assert.Equal("TestFirstName", patient.Firstname);
            Assert.Equal("TestLastName", patient.Lastname);
            Assert.Equal("test@testmail.com", patient.Email);
            Assert.Equal("0470000000", patient.Phonenumber);
            Assert.Equal(dateTime, patient.Birthdate);
        }

        [Fact]
        public void NewPatient_FirstnameIncorrect()
        {
            foreach (string firstname in new[] { "", " ", "  ", "123", "a" })
            {
                Assert.Throws<ArgumentException>(() => new Patient(firstname, "TestLastName", "test@testmail.com", "0470000000", dateTime));
            }
        }

        [Fact]
        public void NewPatient_FirstnameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Patient(null, "TestLastName", "test@testmail.com", "0470000000", dateTime));
        }

        [Fact]
        public void NewPatient_LastnameIncorrect()
        {
            foreach (string lastname in new[] { "", " ", "  ", "123", "a" })
            {
                Assert.Throws<ArgumentException>(() => new Patient("TestFirstName", lastname, "test@testmail.com", "0470000000", dateTime));
            }
        }

        [Fact]
        public void NewPatient_LastnameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Patient("TestFirstName", null, "test@testmail.com", "0470000000", dateTime));
        }

        [Fact]
        public void NewPatient_EmailIncorrect()
        {
            foreach (string email in new[] { "", " ", "  ", "@wrongmail.com", "wrong@wrongmail", "wrongmail.com", "wrong.wrongmail.com" })
            {
                Assert.Throws<ArgumentException>(() => new Patient("TestFirstName", "TestLastName", email, "0470000000", dateTime));
            }
        }

        [Fact]
        public void NewPatient_EmailIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Patient("TestFirstName", "TestLastName", null, "0470000000", dateTime));
        }

        [Fact]
        public void NewPatient_PhonenumberIncorrect()
        {
            foreach (string phoneNumber in new[] { "", " ", "  ", "+3242", "04789", "04561344986123465749843213165847965", "0", "04dz6d98az" })
            {
                Assert.Throws<ArgumentException>(() => new Patient("TestFirstName", "TestLastName", "test@testmail.com", phoneNumber, dateTime));
            }
        }

        [Fact]
        public void NewPatient_PhonenumberIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Patient("TestFirstName", "TestLastName", "test@testmail.com", null, dateTime));
        }

        [Fact]
        public void NewPatient_BirthDateIsIncorrect()
        {
            foreach (DateTime dateTime in new[] {new DateTime(2030, 1, 1), new DateTime(2100, 1, 1) })
            {
                Assert.Throws<ArgumentException>(() => new Patient("TestFirstName", "TestLastName", "test@testmail.com", "0470000000", dateTime));
            }
        }
    }
}
