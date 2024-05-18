using dotnet_grpc.Data;
using dotnet_grpc.Models;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;

namespace dotnet_grpc.Services
{
    public class TodoService(AppDbContext dbContext) : ToDo.ToDoBase
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

        public override async Task<ReadToDoResponse> ReadTodo(ReadToDoRequest request, ServerCallContext context)
        {
            if (request.Id <= 0)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Resource index must be greater than 0"));

            var todoItem = await _dbContext.Todos.FirstOrDefaultAsync(t => t.Id == request.Id);

            if (todoItem is not null)
            {
                return await Task.FromResult(new ReadToDoResponse
                {
                    Id = todoItem.Id,
                    Title = todoItem.Title,
                    Description = todoItem.Description,
                    ToDoStatus = todoItem.ToDoStatus
                });
            }

            throw new RpcException(new Status(StatusCode.NotFound, "Not found"));
        }

        public override async Task<GetAllResponse> ListTodo(GetAllRequest request, ServerCallContext context)
        {
            var response = new GetAllResponse();
            var todoItems = await _dbContext.Todos.ToListAsync();

            foreach (var item in todoItems)
            {
                response.ToDo.Add(new ReadToDoResponse
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    ToDoStatus = item.ToDoStatus
                });
            }

            return await Task.FromResult(response);
        }

        public override async Task<UpdateToDoResponse> UpdateToDo(UpdateToDoRequest request, ServerCallContext context)
        {
            if (request.Id <= 0 || request.Title == string.Empty || request.Description == string.Empty)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid Rquest"));
            }

            var todoItem = await _dbContext.Todos.FirstOrDefaultAsync(t => t.Id == request.Id) ?? throw new RpcException(new Status(StatusCode.NotFound, "Todo not found!"));

            todoItem.Title = request.Title;
            todoItem.Description = request.Description;
            todoItem.ToDoStatus = request.ToDoStatus;

            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(new UpdateToDoResponse
            {
                Id = todoItem.Id,
            });
        }

        public override async Task<DeleteToDoResponse> DeleteToDo(DeleteToDoRequest request, ServerCallContext context)
        {
            if (request.Id <= 0)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid Rquest"));
            }

            var todoItem = await _dbContext.Todos.FirstOrDefaultAsync(t => t.Id == request.Id) ?? throw new RpcException(new Status(StatusCode.NotFound, "No Todo found"));

            _dbContext.Remove(todoItem);
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(new DeleteToDoResponse
            {
                Id = todoItem.Id,
            });
        }
    }
}