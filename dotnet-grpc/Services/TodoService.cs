using dotnet_grpc.Data;
using dotnet_grpc.Models;
using Grpc.Core;

namespace dotnet_grpc.Services
{
    public class TodoService(AppDbContext dbContext) : ToDoIt.ToDoItBase
    {
        private readonly AppDbContext _dbContext = dbContext;

        public override async Task<CreateToDoResponse> CreateToDo(CreateToDoRequest request, ServerCallContext context)
        {
            if (request.Title == string.Empty || request.Description == string.Empty)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid Rquest"));
            }

            var todoItem = new TodoItem
            {
                Title = request.Title,
                Description = request.Description
            };

            await _dbContext.Todos.AddAsync(todoItem);
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(new CreateToDoResponse
            {
                Id = todoItem.Id
            });
        }
    }
}