using Oogarts.Shared.Chats;
using Oogarts.Shared.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Chats
{
    public abstract class ChatResult
    {
        public class Index
        {
            public IEnumerable<ChatDto.Index>? Chats { get; set; }
            public int TotalAmount { get; set; }
        }
    }
}
