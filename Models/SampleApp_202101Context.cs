using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    public class SampleApp_202101Context : DbContext
    {
        public DbSet<SampleModel> SampleModel { get; set; }
        public DbSet<TodoModel> TodoModel { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<DateTimeModel> DateTimeModel { get; set; }
        public DbSet<TextModel> TextModel { get; set; }

    }
}