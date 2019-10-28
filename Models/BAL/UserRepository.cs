using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;
namespace AU_Tasks_App.Models
{
    public class UserRepository:IUserRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public IEnumerable<USERS> GetAllUsers()
        {
            return _context.USERS.ToList<USERS>();
        }

        public int AddUser(USERS au_user)
        {
            int result = -1;
            if (au_user != null)
            {
                _context.USERS.Add(au_user);
                _context.SaveChanges();
                result = au_user.USER_ID;
            }
            return result;
        }

        public int UpdateUser(USERS au_user)
        {
            int result = -1;
            if (au_user != null)
            {
                _context.Entry(au_user).State = EntityState.Modified;
                _context.SaveChanges();
                result = au_user.USER_ID;
            }
            return result;
        }

        public USERS GetUserById(int id)
        {
            return _context.USERS.Find(id);
        }

        public void DeleteUser(int id)
        {
            USERS user = _context.USERS.Find(id);
            _context.USERS.Remove(user);
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}