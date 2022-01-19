using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Items.Models;
using Microsoft.EntityFrameworkCore;

namespace Items.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ToDoItem> ToDoItems { get; set; } = null;
    }
}