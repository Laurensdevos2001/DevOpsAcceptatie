using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oogarts.Services.Businesses;
using Oogarts.Shared.Business;
using Oogarts.Shared.Job;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Jobs
{

    [ApiController]
    [Route("Client/[controller]")]
    [Route("Admin/[controller]")]
    public class JobController : ControllerBase
    {

        private IJobService service;
        
        public JobController(IJobService jobService)
        {
            this.service = jobService;
        }

        [SwaggerOperation("Get all jobs")]
        [HttpGet]
        public async Task<JobResult.Index> GetAll([FromQuery] Shared.Common.Request.Index request)
        {
            return await service.GetIndexAsync(request);
        }

        [SwaggerOperation("Get a job by id")]
        [HttpGet("{jobId}")]
        public async Task<JobDto.Detail> GetDetail(int jobId)
        {
            return await service.GetDetailAsync(jobId);
        }

        [SwaggerOperation("Create a job")]
        [HttpPost]
        public async Task<int> Create(JobDto.Mutate model)
        {
            return await service.CreateAsync(model);
        }

        [SwaggerOperation("Edit a job")]
        [HttpPut("{jobId}")]
        public async Task Edit(int jobId, JobDto.Mutate model)
        {
            await service.EditAsync(jobId, model);
        }

        [SwaggerOperation("Delete a job")]
        [HttpDelete("{jobId}")]
        public async Task Remove(int jobId)
        {
            await service.RemoveAsync(jobId);
        }

    }
}
