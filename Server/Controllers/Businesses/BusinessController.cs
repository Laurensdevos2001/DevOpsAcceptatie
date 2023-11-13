using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Business;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Businesses;

[ApiController]
[Route("Client/[controller]")]
[Route("Admin/[controller]")]
public class BusinessController : ControllerBase
{
    private IBusinessService businessService;

    public BusinessController(IBusinessService service)
    {
        businessService = service;
    }

    [SwaggerOperation("Get all businesses")]
    [HttpGet]
    public async Task<BusinessResult.Index> GetAll([FromQuery] Shared.Common.Request.Index request)
    {
        return await businessService.GetIndexAsync(request);
    }

    [SwaggerOperation("Get a business by id")]
    [HttpGet("{businessId}")]
    public async Task<BusinessDto.Detail> GetDetail(int businessId)
    {
        return await businessService.GetDetailAsync(businessId);
    }

    [SwaggerOperation("Create a business")]
    [HttpPost]
    public async Task<int> Create(BusinessDto.Mutate model)
    {
        return await businessService.CreateAsync(model);
    }

    [SwaggerOperation("Edit a business")]
    [HttpPut("{businessId}")]
    public async Task Edit(int businessId, BusinessDto.Mutate model)
    {
        await businessService.EditAsync(businessId, model);
    }

    [SwaggerOperation("Delete a business")]
    [HttpDelete("{businessId}")]
    public async Task Remove(int businessId)
    {
        await businessService.RemoveAsync(businessId);
    }

}
