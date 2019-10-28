using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AU_Tasks_App.Models;

namespace AU_Tasks_App.Models.BAL
{
    public interface IStaffAttendenceRepository:IDisposable
    {
        IEnumerable<STAFF_ATTENDENCE> GetAllAttandence();
        IEnumerable<STAFF_ATTENDENCE> GetAllAttandenceById(Int64 id);
        IEnumerable<STAFF_ATTENDENCE> GetAllAttandenceByDate(string fromDate, string toDate);
        Int64 AddAttendence(STAFF_ATTENDENCE staff_attendence);
        Int64 UpdateAttendence(STAFF_ATTENDENCE staff_attendence);
        void DeleteAttendence(Int64 id);
    }
}
