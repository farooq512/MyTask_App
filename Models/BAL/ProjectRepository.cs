using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;

namespace AU_Tasks_App.Models
{
    public class ProjectRepository:IProjectRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public IEnumerable<PROJECT> GetAllProjects()
        {
            return _context.PROJECT.ToList<PROJECT>();
        }

        public PROJECT GetProjectById(int id)
        {
            return _context.PROJECT.Find(id);
        }

        public long AddProject(PROJECT project)
        {
            int result = -1;
            if (project != null)
            {
                _context.PROJECT.Add(project);
                _context.SaveChanges();
                result = project.PROJECT_ID;
            }
            return result;
        }

        public long UpdateAddProject(PROJECT project)
        {
            int result = -1;
            if (project != null)
            {
                _context.Entry(project).State = EntityState.Modified;
                _context.SaveChanges();
                result = project.PROJECT_ID;
            }
            return result;
        }

        public void DeleteProject(int id)
        {
            PROJECT project = _context.PROJECT.Find(id);
            _context.PROJECT.Remove(project);
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