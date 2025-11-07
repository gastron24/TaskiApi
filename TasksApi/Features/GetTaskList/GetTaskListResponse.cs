namespace TaskApi.Features.GetTaskList;

public record GetTaskListResponse(Guid Id, string Title, string? Description, bool IsCompleted, DateTime CreatedAt);