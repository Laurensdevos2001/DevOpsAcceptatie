using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Staffs;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Staffs
{
    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService service)
        {
            staffService = service;
        }

        [SwaggerOperation("Returns a list of staff members")]
        [HttpGet]
        public async Task<StaffResult.Index> GetIndex([FromQuery] StaffRequest.Index request)
        {
            return await staffService.GetIndexAsync(request);
        }

        [SwaggerOperation("Returns a staff by id")]
        [HttpGet("{staffId}")]
        public async Task<StaffDto.Detail> GetDetail(int staffId)
        {
            return await staffService.GetDetailAsync(staffId);
        }

        [SwaggerOperation("Creates a new staff member")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StaffDto.Mutate model)
        {
            var staffId = await staffService.CreateAsync(model);
            return CreatedAtAction(nameof(Create), staffId);
        }

        [SwaggerOperation("Edits an existing staff member")]
        [HttpPut("{staffId}")]
        public async Task Edit(int staffId, [FromBody] StaffDto.Mutate model)
        {
            await staffService.EditAsync(staffId, model);
        }

        [SwaggerOperation("Removes an existing member")]
        [HttpDelete("{staffId}")]
        public async Task Remove(int staffId)
        {
            await staffService.RemoveAsync(staffId);
        }
    }

}
