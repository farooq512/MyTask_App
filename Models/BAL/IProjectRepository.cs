using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;

namespace AU_Tasks_App.Models
{
    public interface IProjectRepository:IDisposable
    {
        IEnumerable<PROJECT> GetAllProjects();
        PROJECT GetProjectById(int id);
        Int64 AddProject(PROJECT project);
        Int64 UpdateAddProject(PROJECT project);
        void DeleteProject(int id);
    }
}
