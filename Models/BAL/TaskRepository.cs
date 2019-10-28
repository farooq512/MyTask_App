using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;

namespace AU_Tasks_App.Models.BAL
{
    public class TaskRepository:ITaskRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public TaskRepository(AU_TasksEntities context)
        {
            _context = context;
        }

        public IEnumerable<AU_TASK> GetAllTask()
        {
            return _context.AU_TASK.ToList();
        }

        public int AddTask(AU_TASK au_task)
        {
            int result = -1;
            if (au_task != null)
            {
                _context.AU_TASK.Add(au_task);
                _context.SaveChanges();
                result = au_task.TASK_ID;
            }
            return result;
        }

        public int UpdateTask(AU_TASK au_task)
        {
             int result = -1;
             if (au_task != null)
             {
//                 This line of code is telling the data context about an object whose values already live in the database
//(this is not a brand-new album, but an existing album), so the framework should apply the values
//inside to an existing album and not try to create a new album record. The next line of code invokes
//SaveChanges on the data context, and at this point the context formulates a SQL UPDATE command
//to persist the new values.
                 _context.Entry(au_task).State = EntityState.Modified;
                 _context.SaveChanges();
                 result = au_task.TASK_ID;
             }
             return result;
        }

        public AU_TASK GetTaskById(int id)
        {
            AU_TASK task = _context.AU_TASK.Find(id);
            return task;
        }

        public void DeleteTask(int id)
        {
            AU_TASK task= _context.AU_TASK.Find(id);
            _context.AU_TASK.Remove(task);
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