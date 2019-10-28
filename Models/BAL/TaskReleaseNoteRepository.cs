using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;

namespace AU_Tasks_App.Models.BAL
{
    public class TaskReleaseNoteRepository:ITaskReleaseNoteRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public IEnumerable<TASK_RELEASE_NOTE> GetTaskReleaseNoteByTaskId(int id)
        {
            return _context.TASK_RELEASE_NOTE.Where(notes => notes.TASK_ID == id).ToList<TASK_RELEASE_NOTE>();
        }

        public long AddTaskReleaseNote(TASK_RELEASE_NOTE task_release_note)
        {
            Int64 result = -1;
            if (task_release_note != null)
            {
                _context.TASK_RELEASE_NOTE.Add(task_release_note);
                _context.SaveChanges();
                result = task_release_note.NOTE_ID;
            }
            return result;
        }

        public long UpdateTaskReleaseNote(TASK_RELEASE_NOTE task_release_note)
        {
            Int64 result = -1;
            if (task_release_note != null)
            {
                _context.Entry(task_release_note).State = EntityState.Modified;
                _context.SaveChanges();
                result = task_release_note.NOTE_ID;
            }
            return result;
        }

        public void DeleteTaskReleaseNote(long id)
        {
            TASK_RELEASE_NOTE note = _context.TASK_RELEASE_NOTE.Find(id);
            _context.TASK_RELEASE_NOTE.Remove(note);
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