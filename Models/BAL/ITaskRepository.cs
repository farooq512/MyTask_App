using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;

namespace AU_Tasks_App.Models
{
    public interface ITaskRepository:IDisposable
    {
        IEnumerable<AU_TASK> GetAllTask();
        int AddTask(AU_TASK au_task);
        int UpdateTask(AU_TASK au_task);
        AU_TASK GetTaskById(int id);
        void DeleteTask(int id);
      
        

    }
}
