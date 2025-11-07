using MediatR;
using TaskApi.Features.DeleteTask;

namespace TaskApi.Features.DeleteTask;

public record DeleteTaskCommand(Guid Id) : IRequest;