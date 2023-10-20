using Aplication.Services;
using Domain.Models;
using Domain.Users;
using Infrastructure.DataAction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserServise : IUser
    {
        public readonly UserDbContext _userDb;

        public UserServise(UserDbContext userDb)
        {
            _userDb = userDb;
        }

        public async Task<User> CreateAsync(User entity)
        {
            _userDb.Attach(entity);
             await _userDb.SaveChangesAsync();
            return entity ;

        }

        public Task<T> CreateAsync<T>()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            User entity = await _userDb.FindAsync(Id);
            if (entity == null)
                return false;

            _userDb.Remove(entity);
            _userDb.SaveChanges();
            return true;
        }

        public Task DeleteAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            _userDb.User.AsNoTracking().AsEnumerable();
            return Task.FromResult(Enumerable.Empty<User>());
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            User entity = await _userDb.FindAsync(Id);
            return entity;
        }

        public  async Task<bool> UpdateAsync(User entity)
        {
            _userDb.Update(entity);
            var executeRows = await _userDb.SaveChangesAsync();
            return executeRows > 0;
        }

        public Task UpdateAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}
