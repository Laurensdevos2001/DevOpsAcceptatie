using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Chats;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Chats
{
    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class ChatController : ControllerBase
    {

        private IChatService service;
        
        public ChatController( IChatService service)
        {
            this.service = service;
        }

        [SwaggerOperation("Get all chats")]
        [HttpGet]
        public async Task<ChatResult.Index> GetAll([FromQuery] Shared.Common.Request.Index request)
        {
            return await service.GetIndexAsync(request);
        }

        [SwaggerOperation("Get a chat by id")]
        [HttpGet("{chatId}")]
        public async Task<ChatDto.Detail> GetDetail(int chatId)
        {
            return await service.GetDetailAsync(chatId);
        }

        [SwaggerOperation("Create a chat")]
        [HttpPost]
        public async Task<int> Create(ChatDto.Mutate model)
        {
            return await service.CreateAsync(model);
        }

        [SwaggerOperation("Edit a job")]
        [HttpPut("{chatId}")]
        public async Task Edit(int chatId, ChatDto.Mutate model)
        {
            await service.EditAsync(chatId, model);
        }

        [SwaggerOperation("Delete a chat")]
        [HttpDelete("{chatId}")]
        public async Task Remove(int chatId)
        {
            await service.RemoveAsync(chatId);
        }
    }
}
