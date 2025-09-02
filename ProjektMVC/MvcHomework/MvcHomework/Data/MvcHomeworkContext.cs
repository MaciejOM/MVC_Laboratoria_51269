using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcHomework.Models;

namespace MvcHomework.Data
{
    public class MvcHomeworkContext : DbContext
    {
        public MvcHomeworkContext (DbContextOptions<MvcHomeworkContext> options)
            : base(options)
        {
        }

        public DbSet<MvcHomework.Models.Homework> Homework { get; set; } = default!;
    }
}
