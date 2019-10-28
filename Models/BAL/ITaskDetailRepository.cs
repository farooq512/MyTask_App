using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;

namespace AU_Tasks_App.Models
{
    public interface ITaskDetailRepository:IDisposable
    {
        IEnumerable<TASK_DETAIL> GetTaskDetailByTaskId(int id);
        Int64 AddTaskDetail(TASK_DETAIL task_detail);
        Int64 UpdateTaskDetail(TASK_DETAIL task_detail);
        void DeleteTaskDetail(Int64 id);
    }
}
