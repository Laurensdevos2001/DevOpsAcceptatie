using Oogarts.Domain.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tests.Domain
{
    public class DiseaseTest
    {
        [Fact]
        public void NewDisease_CreatedCorrectly()
        {
            Disease disease = new Disease(1, "Test2", "Test3");
            Assert.NotNull(disease);
            Assert.Equal(1, disease.AuthorId);
            Assert.Equal("Test2", disease.Content);
            Assert.Equal("Test3", disease.Name);
        }

        [Fact]
        public void NewDisease_AuthorIdIncorrect() 
        {
           foreach (int authorId in new[] {0, -1})
            {
                Assert.Throws<ArgumentException>(() => _ = new Disease(authorId, "Test1", "Test2"));
            }
        }

        [Fact]
        public void NewDisease_ContentIncorrect()
        {
            foreach (string content in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Disease(1, content, "Test2"));
            }
        }

        [Fact]
        public void NewDisease_ContentIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Disease(1, null, "Test2"));
        }

        [Fact]
        public void NewDisease_NameIncorrect()
        {
            foreach (string name in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Disease(1, "Test2", name));
            }
        }

        [Fact]
        public void NewDisease_AuthorIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Disease(1, "Test2", null));
        }
    }
}
