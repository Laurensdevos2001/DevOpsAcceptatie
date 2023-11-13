using Oogarts.Domain.Businesses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tests.Domain
{
    public class BusinessTest
    {
        [Fact]
        public void NewBusiness_CreatedCorrectly()
        {
            Business business = new Business("Test1", "Test2", "Test3", "Test4", "Test5", "Test6", "test@testmail.com", "Test7");
            Assert.NotNull(business);
            Assert.Equal("Test1", business.Name);
            Assert.Equal("Test2", business.City);
            Assert.Equal("Test3", business.PostalCode);
            Assert.Equal("Test4", business.Street);
            Assert.Equal("Test5", business.HouseNumber);
            Assert.Equal("Test6", business.Phone);
            Assert.Equal("test@testmail.com", business.ContactEmail);
            Assert.Equal("Test7", business.Logo);
        }

        [Fact]
        public void NewBusiness_NameIncorrect()
        {
            foreach (string name in new[] {"", " ", "   "})
            {
                Assert.Throws<ArgumentException>(() => _ = new Business(name, "Test1", "Test2", "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_NameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business(null, "Test1", "Test2", "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_CityIncorrect()
        {
            foreach (string city in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", city, "Test2", "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_CityIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", null, "Test2", "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_PostalCodeIncorrect()
        {
            foreach (string postalCode in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", postalCode, "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_PostalCodeIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", null, "Test3", "Test4", "Test5", "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_StreetIncorrect()
        {
            foreach (string street in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", "Test3", street, "Test4", "Test5", "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_StreetIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", "Test3", null, "Test4", "Test5", "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_HouseNumberIncorrect()
        {
            foreach (string houseNumber in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", houseNumber, "Test5", "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_HouseNumberIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", null, "Test5", "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_PhoneIncorrect()
        {
            foreach (string phone in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", phone, "test@testmail.com", "Test6"));
            }
        }

        [Fact]
        public void NewBusiness_PhoneIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", null, "test@testmail.com", "Test6"));
        }

        [Fact]
        public void NewBusiness_ContactEmailIncorrect()
        {
            foreach (string contactEmail in new[] { "", " ", "   ", "@wrongmail.com", "wrong@wrongmail", "wrongmail.com", "wrong.wrongmail.com" })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", "Test6", contactEmail, "Test7"));
            }
        }

        [Fact]
        public void NewBusiness_ContactEmailIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", "Test6", null, "Test7"));
        }

        [Fact]
        public void NewBusiness_LogoIncorrect()
        {
            foreach (string logo in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", "Test6","test@testmail.com", logo));
            }
        }

        [Fact]
        public void NewBusiness_LogoIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Business("Test1", "Test2", "Test3", "Test4", "Test5", "Test6", "test@testmail.com", null));
        }
    }
}
