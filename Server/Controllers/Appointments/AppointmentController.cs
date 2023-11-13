using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Appointments;
using Oogarts.Shared.Posts;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Appointments
{
    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        [SwaggerOperation("Get all appointments")]
        [HttpGet]
        public async Task<AppointmentResult.Index> GetIndex([FromQuery] Shared.Common.Request.Index request)
        {
            return await appointmentService.GetIndexAsync(request);
        }

        [SwaggerOperation("Get appointment by id")]
        [HttpGet("{appointmentId}")]
        public async Task<AppointmentDto.Detail> GetDetail(int appointmentId)
        {
            return await appointmentService.GetDetailAsync(appointmentId);
        }

        [SwaggerOperation("Create appointment")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AppointmentDto.Mutate model)
        {
            var appointmentId = await appointmentService.CreateAsync(model);
            return CreatedAtAction(nameof(Create), appointmentId);
        }

        [SwaggerOperation("Edit appointment")]
        [HttpPut("{appointmentId}")]
        public async Task Edit(int appointmentId, [FromBody] AppointmentDto.Mutate model)
        {
            await appointmentService.EditAsync(appointmentId, model);
        }

        [SwaggerOperation("Remove appointment")]
        [HttpDelete("{appointmentId}")]
        public async Task Remove(int appointmentId)
        {
            await appointmentService.RemoveAsync(appointmentId);
        }

    }
}
