using ManageTasks.Entities;
using ManageTasks.Features.CreateTask;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ManageTasks.Entities;
using TaskApi.Infrastructure;

namespace TaskApi.Features.CreateTask;

public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, CreateTaskResponse>
{
    private readonly ApplicationDbContext _context;

    public CreateTaskCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CreateTaskResponse> Handle(CreateTaskCommand request, CancellationToken ct)
    {
        var task = new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = request.Request.Title,
            Description = request.Request.Description,
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow
        };

        _context.Tasks.Add(task);
        await _context.SaveChangesAsync(ct);

        return new CreateTaskResponse(task.Id, task.Title, task.Description, task.IsCompleted, task.CreatedAt);
    }
}