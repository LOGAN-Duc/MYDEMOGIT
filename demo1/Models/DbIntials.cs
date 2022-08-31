using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;

namespace demo1.Models
{
    public static class DbIntials
    {
        public static void Initial(Datacontext context, IConfiguration configuration)
        {
            if (!((RelationalDatabaseCreator)context.Database.GetService<IDatabaseCreator>()).Exists())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
