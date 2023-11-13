using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.OpeningHours;
using Oogarts.Shared.Posts;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.OpeningHours
{
    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class OpeningHourController : ControllerBase
    {

        private IOpeningHourService service;
        public OpeningHourController(IOpeningHourService openingHourService)
        {
            this.service = openingHourService;
        }

        [SwaggerOperation("Get all OpeningHours")]
        [HttpGet]
        public async Task<OpeningHourResult.Index> GetIndexAsync([FromQuery] Shared.Common.Request.Index request)
        {
            return await service.GetIndexAsync(request);
        }

        [SwaggerOperation("Get openinghour by id")]
        [HttpGet("{openinghourId}")]
        public async Task<OpeningHourDto.Detail> GetDetail(int openinghourId)
        {
            return await service.GetDetailAsync(openinghourId);
        }

        [SwaggerOperation("Create openinghour")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OpeningHourDto.Mutate model)
        {
            var openinghourId = await service.CreateAsync(model);
            return CreatedAtAction(nameof(Create), openinghourId);
        }

        [SwaggerOperation("Edit openinghour")]
        [HttpPut("{openinghourId}")]
        public async Task Edit(int openinghourId, [FromBody] OpeningHourDto.Mutate model)
        {
            await service.EditAsync(openinghourId, model);
        }

        [SwaggerOperation("Remove openinghour")]
        [HttpDelete("{openinghourId}")]
        public async Task Remove(int openinghourId)
        {
            await service.RemoveAsync(openinghourId);
        }
    }
}
