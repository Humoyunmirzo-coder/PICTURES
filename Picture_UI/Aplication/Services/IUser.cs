using Aplication.Repository;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public  interface IUser  : IRepository<User>
    {
      //  public Task < T> CreateAsync<T> ();
    }
}
