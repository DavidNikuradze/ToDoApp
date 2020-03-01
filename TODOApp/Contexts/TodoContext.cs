using Microsoft.EntityFrameworkCore;
using TODOApp.Models.db;

namespace TODOApp.Contexts
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
