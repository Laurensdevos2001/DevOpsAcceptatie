using Oogarts.Domain.Accounts;
using Oogarts.Domain.Diseases;
using Oogarts.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain
{
    public class PostTest
    {
        Account author = new Account("TestName", "TestPw");

        [Fact]
        public void NewPost_CreatedCorrectly()
        {
            Post post = new Post(author, "Test2", "Test3");
            Assert.NotNull(post);
            Assert.Equal("TestName", post.Author.Username);
            Assert.Equal("Test2", post.Title);
            Assert.Equal("Test3", post.Content);
        }

        [Fact]
        public void NewPost_AuthorIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Post(null, "Test2", "Test3"));
        }

        [Fact]
        public void NewPost_TitleIncorrect()
        {
            foreach (string title in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Post(author, title, "Test2"));
            }
        }

        [Fact]
        public void NewPost_TitleIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Post(author, null, "Test2"));
        }

        [Fact]
        public void NewPost_ContentIncorrect()
        {
            foreach (string content in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Post(author, "Test2", content));
            }
        }

        [Fact]
        public void NewPost_ContentIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Post(author, "Test2", null));
        }
    }
}
