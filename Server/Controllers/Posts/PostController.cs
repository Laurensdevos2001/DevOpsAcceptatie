using Microsoft.AspNetCore.Mvc;
using Oogarts.Shared.Appointments;
using Oogarts.Shared.Diseases;
using Oogarts.Shared.Patients;
using Oogarts.Shared.Posts;
using Swashbuckle.AspNetCore.Annotations;

namespace Oogarts.Server.Controllers.Posts;

[ApiController]
[Route("Client/[controller]")]
[Route("Admin/[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService service;

    public PostController(IPostService service)
    {
        this.service = service;
    }

    [SwaggerOperation("Get all posts")]
    [HttpGet]
    public async Task<PostResult.Index> GetIndex([FromQuery] Shared.Common.Request.Index request)
    {
        return await service.GetIndexAsync(request);
    }

    [SwaggerOperation("Get post by id")]
    [HttpGet("{postId}")]
    public async Task<PostDto.Detail> GetDetail(int postId)
    {
        return await service.GetDetailAsync(postId);
    }

    [SwaggerOperation("Create post")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostDto.Mutate model)
    {
        var postId= await service.CreateAsync(model);
        return CreatedAtAction(nameof(Create), postId);
    }

    [SwaggerOperation("Edit post")]
    [HttpPut("{postId}")]
    public async Task Edit(int postId, [FromBody] PostDto.Mutate model)
    {
        await service.EditAsync(postId, model);
    }

    [SwaggerOperation("Remove post")]
    [HttpDelete("{postId}")]
    public async Task Remove(int postId)
    {
        await service.RemoveAsync(postId);
    }
}
