using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Appointments;
using Oogarts.Shared.Diseases;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Diseases;

[ApiController]
[Route("Client/[controller]")]
[Route("Admin/[controller]")]
public class DiseaseController : ControllerBase
{
    private readonly IDiseaseService service;

    public DiseaseController(IDiseaseService service)
    {
        this.service = service;
    }

    [SwaggerOperation("Get all diseases")]
    [HttpGet]
    public async Task<ActionResult<DiseaseResult.Index>> GetIndex([FromQuery] Shared.Common.Request.Index request)
    {
        return await service.GetIndexAsync(request);
    }

    [SwaggerOperation("Get a disease by id")]
    [HttpGet("{diseaseId}")]
    public async Task<ActionResult<DiseaseDto.Detail>> GetDetail(int diseaseId)
    {
        return await service.GetDetailAsync(diseaseId);
    }

    [SwaggerOperation("Create a disease")]
    [HttpPost]
    public async Task<ActionResult> Create(DiseaseDto.Mutate model)
    {
        var diseaseId = await service.CreateAsync(model);
        return CreatedAtAction(nameof(Create), diseaseId);
    }

    [SwaggerOperation("Edit a disease")]
    [HttpPut("{diseaseId}")]
    public async Task<ActionResult> Edit(int diseaseId, DiseaseDto.Mutate model)
    {
        await service.EditAsync(diseaseId, model);
        return NoContent();
    }

    [SwaggerOperation("Remove a disease")]
    [HttpDelete("{diseaseId}")]
    public async Task<ActionResult> Remove(int diseaseId)
    {
        await service.RemoveAsync(diseaseId);
        return NoContent();
    }
}
