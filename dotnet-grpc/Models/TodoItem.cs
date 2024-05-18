using System.Runtime.ConstrainedExecution;

namespace dotnet_grpc.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ToDoStatus { get; set; } = "NEW";
    }
}