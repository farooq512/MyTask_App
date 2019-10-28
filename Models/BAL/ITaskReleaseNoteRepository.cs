using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;


namespace AU_Tasks_App.Models.BAL
{
    public interface ITaskReleaseNoteRepository:IDisposable
    {
        IEnumerable<TASK_RELEASE_NOTE> GetTaskReleaseNoteByTaskId(int id);
        Int64 AddTaskReleaseNote(TASK_RELEASE_NOTE task_release_note);
        Int64 UpdateTaskReleaseNote(TASK_RELEASE_NOTE task_release_note);
        void DeleteTaskReleaseNote(Int64 id);
    }
}
