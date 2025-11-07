namespace TaskApi.Features.CreateTask;

public record CreateTaskResponse(Guid Id, string Title, string? Description, bool IsCompleted, DateTime CreatedAt);