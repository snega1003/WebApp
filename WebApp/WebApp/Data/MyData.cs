using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Data
{
    public class MyData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.ContactBase.Any())
                {
                    return;
                }

                context.ContactBase.AddRange(
                    new Contact
                    {
                        Name = "Rick",
                        Age = 40
                    },
                    new Contact
                    {
                        Name = "Morty",
                        Age = 14
                    }
                    );
                context.SaveChanges();
            }
            //    context.Database.EnsureCreated();
            //if (context.ContactBase.Any())
            //{
            //    return;
            //}
            //context.ContactBase.Add(new Contact { Name = "dfsdf", Age = 5 });


        }
    }
}
