namespace TaskApi.Features.UpdateTask;

public record UpdateTaskResponse(Guid Id, string Title, string? Description, bool IsCompleted, DateTime CreatedAt);