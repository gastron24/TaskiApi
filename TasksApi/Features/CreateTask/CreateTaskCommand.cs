using MediatR;
using TaskApi.Features.CreateTask;

namespace ManageTasks.Features.CreateTask;

public record CreateTaskCommand(CreateTaskRequest Request) : IRequest<CreateTaskResponse>;