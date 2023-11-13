using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oogarts.Domain.Chats;

namespace Tests.Domain
{
    public class ChatTest
    {
        [Fact]
        public void NewChat_CreatedCorrectly()
        {
            Chat chat = new Chat("Test1");
            Assert.NotNull(chat);
            Assert.Equal("Test1", chat.Message);
        }

        [Fact]
        public void NewChat_MessageIncorrect()
        {
            foreach (string message in new[] { "", " ", "   " })
            {
                Assert.Throws<ArgumentException>(() => _ = new Chat(message));
            }
        }

        [Fact]
        public void NewChat_MessageIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Chat(null));
        }
        
    }
}
