namespace TaskApi.Features.CreateTask;

public record CreateTaskRequest(string Title, string? Description = null);