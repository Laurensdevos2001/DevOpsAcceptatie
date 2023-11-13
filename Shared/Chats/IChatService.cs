using Oogarts.Shared.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Chats
{
    public interface IChatService
    {
        Task<ChatDto.Detail> GetDetailAsync(int chatId);
        Task<ChatResult.Index> GetIndexAsync(ChatRequest.Index request);
        Task<int> CreateAsync(ChatDto.Mutate model);
        Task EditAsync(int chatId, ChatDto.Mutate model);
        Task RemoveAsync(int chatId);
    }
}
