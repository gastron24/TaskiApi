using MediatR;
using TaskApi.Features.UpdateTask;

namespace TaskApi.Features.UpdateTask;

public record UpdateTaskCommand(Guid Id, UpdateTaskRequest Request) : IRequest<UpdateTaskResponse>;