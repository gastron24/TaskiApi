using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Features.CreateTask;

using TaskApi.Features.UpdateTask;
using TaskApi.Features.DeleteTask;
using TaskApi.Features.GetTaskList;

namespace ManageTasks.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly IMediator _mediator;

    public TasksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTaskRequest request, CancellationToken ct)
    {
        var response = await _mediator.Send(new CreateTaskCommand(request), ct);
        return Ok(response); 
    }

    [HttpGet]
    public async Task<IActionResult> GetList(
        [FromQuery] bool? isCompleted = null,
        [FromQuery] string? sortBy = "createdAt",
        [FromQuery] string? sortOrder = "asc",
        CancellationToken ct = default)
    {
        var query = new GetTaskListQuery(isCompleted, sortBy, sortOrder);
        var response = await _mediator.Send(query, ct);
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTaskRequest request, CancellationToken ct)
    {
        var response = await _mediator.Send(new UpdateTaskCommand(id, request), ct);
        return Ok(response);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteTaskCommand(id), ct);
        return NoContent();
    }
}