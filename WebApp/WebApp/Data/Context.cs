using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class Context : DbContext
    {
        public DbSet<Contact> ContactBase;
        public DbSet<Message> MessageBase;
        public Context (DbContextOptions<Context> options)
        {

        }
       
    }
}
