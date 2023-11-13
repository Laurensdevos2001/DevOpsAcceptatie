using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Patients;
using Oogarts.Shared.Posts;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Patients
{
    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService service;

        public PatientController(IPatientService service)
        {
            this.service = service;
        }

        [SwaggerOperation("Get all patients")]
        [HttpGet]
        public async Task<PatientResult.Index> GetIndex([FromQuery] Shared.Common.Request.Index request)
        {
            return await service.GetIndexAsync(request);
        }

        [SwaggerOperation("Get patient by id")]
        [HttpGet("{patientId}")]
        public async Task<PatientDto.Detail> GetDetail(int patientId)
        {
            return await service.GetDetailAsync(patientId);
        }

        [SwaggerOperation("Create patient")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PatientDto.Mutate model)
        {
            var patientId = await service.CreateAsync(model);
            return CreatedAtAction(nameof(Create), patientId);
        }

        [SwaggerOperation("Edit patient")]
        [HttpPut("{patientId}")]
        public async Task Edit(int patientId, [FromBody] PatientDto.Mutate model)
        {
            await service.EditAsync(patientId, model);
        }

        [SwaggerOperation("Remove patient")]
        [HttpDelete("{patientId}")]
        public async Task Remove(int patientId)
        {
            await service.RemoveAsync(patientId);
        }
    }
}
