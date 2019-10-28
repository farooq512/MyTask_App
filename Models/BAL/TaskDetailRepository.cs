using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;

namespace AU_Tasks_App.Models
{
    public class TaskDetailRepository:ITaskDetailRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public IEnumerable<TASK_DETAIL> GetTaskDetailByTaskId(int id)
        {
            return _context.TASK_DETAIL.Where(t => t.TASK_ID == id).ToList<TASK_DETAIL>();
        }

        public long AddTaskDetail(TASK_DETAIL task_detail)
        {
            Int64 result = -1;
            if (task_detail != null)
            {
                _context.TASK_DETAIL.Add(task_detail);
                _context.SaveChanges();
                result = task_detail.TASK_DETAIL_ID;
            }
            return result;
        }

        public long UpdateTaskDetail(TASK_DETAIL task_detail)
        {
            Int64 result = -1;
            if (task_detail != null)
            {
                _context.Entry(task_detail).State = EntityState.Modified;
                _context.SaveChanges();
                result = task_detail.TASK_DETAIL_ID;
            }
            return result;
        }

        public void DeleteTaskDetail(long id)
        {
            TASK_DETAIL taskDetail = _context.TASK_DETAIL.Find(id);
            _context.TASK_DETAIL.Remove(taskDetail);
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