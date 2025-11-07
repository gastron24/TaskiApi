namespace TaskApi.Features.UpdateTask;

public record UpdateTaskRequest(string? Title = null, string? Description = null, bool? IsCompleted = null);