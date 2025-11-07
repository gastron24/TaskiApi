using MediatR;
using TaskApi.Features.GetTaskList;

namespace TaskApi.Features.GetTaskList;

public record GetTaskListQuery(bool? IsCompleted, string SortBy, string SortOrder) : IRequest<List<GetTaskListResponse>>;