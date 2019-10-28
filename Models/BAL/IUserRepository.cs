using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;

namespace AU_Tasks_App.Models
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<USERS> GetAllUsers();
        int AddUser(USERS au_task);
        int UpdateUser(USERS au_task);
        USERS GetUserById(int id);
        void DeleteUser(int id);
    }
}
