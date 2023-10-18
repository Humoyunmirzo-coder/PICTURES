using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Repository
{
   public  interface IRepository <T> 
    {
        Task<T> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
    }
}
