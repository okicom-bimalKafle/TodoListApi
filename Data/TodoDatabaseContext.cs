using Microsoft.EntityFrameworkCore;
using TodoListApi.Model;

namespace TodoListApi.Data
{
    public class TodoDatabaseContext : DbContext
    {
        public TodoDatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
