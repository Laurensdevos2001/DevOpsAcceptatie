using Oogarts.Domain.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain
{
    public class StaffTest
    {
        [Fact]
        public void NewStaffMember_CreatedCorrectly()
        {
            Staff staffMember = new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5");
            Assert.NotNull(staffMember);
            Assert.Equal("Test1", staffMember.Firstname);
            Assert.Equal("Test1", staffMember.Lastname);
            Assert.Equal("Test1", staffMember.Email);
            Assert.Equal("Test1", staffMember.Phonenumber);
            Assert.Equal("Test1", staffMember.Specialization);
            Assert.Equal(1, staffMember.JobId);
            Assert.Equal("Test1", staffMember.CurriculemVitae);
            Assert.Equal("Test1", staffMember.Image);
        }

        [Fact]
        public void NewStaffMember_FirstnameIncorrect()
        {
            foreach (string firstname in new[] {"", " ", "  ", "123", "a"} )
            {
                Assert.Throws<ArgumentException>(() => new Staff(firstname, "Test1", "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_FirstnameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff(null, "Test1", "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5"));
        }

        [Fact]
        public void NewStaffMember_LastnameIncorrect()
        {
            foreach (string lastname in new[] { "", " ", "  ", "123", "a" })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", lastname, "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_LastnameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", null, "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5"));
        }

        [Fact]
        public void NewStaffMember_EmailIncorrect()
        {
            foreach (string email in new[] { "", " ", "  ", "@wrongmail.com", "wrong@wrongmail", "wrongmail.com", "wrong.wrongmail.com" })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", email, "0470000000", "Test3", 1, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_EmailIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", "Test2", null, "0470000000", "Test3", 1, "Test4", "Test5"));
        }

        [Fact]
        public void NewStaffMember_PhonenumberIncorrect()
        {
            foreach (string phoneNumber in new[] { "", " ", "  ", "+3242", "04789", "04561344986123465749843213165847965", "0", "04dz6d98az" })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", "test@testmail.com", phoneNumber, "Test3", 1, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_PhonenumberIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", "Test2", "test@testmail.com", null, "Test3", 1, "Test4", "Test5"));
        }

        [Fact]
        public void NewStaffMember_SpecializationIncorrect()
        {
            foreach (string specialization in new[] { "", " ", "  ", "123", "a" })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", specialization, 1, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_SpecializationIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", null, 1, "Test4", "Test5"));
        }

        [Fact]
        public void NewStaffMember_JobIdIncorrect()
        {
            foreach (int jobId in new[] {0,-1})
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", jobId, "Test4", "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_CurriculemVitaeIncorrect()
        {
            foreach (string curriculemVitae in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, curriculemVitae, "Test5"));
            }
        }

        [Fact]
        public void NewStaffMember_CurriculemVitaeIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, null, "Test5"));
        }

        [Fact]
        public void NewStaffMember_ImageIncorrect()
        {
            foreach (string image in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, "Test4", image));
            }
        }

        [Fact]
        public void NewStaffMember_ImageIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, "Test4", null));
        }
    }
}
