using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAction
{
    public  class UserDbContext : DbContext 
    {
        public UserDbContext() { }

        public UserDbContext ( DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }
       public  DbSet<User> User { get; set; }

        internal Task<User> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
