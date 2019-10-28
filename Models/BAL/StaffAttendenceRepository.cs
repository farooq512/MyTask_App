using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AU_Tasks_App.Models;
using System.Data;
using System.Data.Entity;

namespace AU_Tasks_App.Models.BAL
{
    public class StaffAttendenceRepository:IStaffAttendenceRepository
    {
        private readonly AU_TasksEntities _context;
        private bool disposed = false;
        public IEnumerable<STAFF_ATTENDENCE> GetAllAttandence()
        {
            return _context.STAFF_ATTENDENCE.ToList<STAFF_ATTENDENCE>();
        }

        public IEnumerable<STAFF_ATTENDENCE> GetAllAttandenceById(Int64 id)
        {
            return _context.STAFF_ATTENDENCE.Where(a => a.ID == id).ToList<STAFF_ATTENDENCE>();
        }

        public IEnumerable<STAFF_ATTENDENCE> GetAllAttandenceByDate(string fromDate, string toDate)
        {
            return _context.STAFF_ATTENDENCE.
                                                Where(a => a.CREATED_DATE <= Convert.ToDateTime(fromDate) && a.CREATED_DATE<=Convert.ToDateTime(toDate)).ToList();
        }

        public Int64 AddAttendence(STAFF_ATTENDENCE staff_attendence)
        {
            Int64 result = -1;
            if (staff_attendence != null)
            {
                _context.STAFF_ATTENDENCE.Add(staff_attendence);
                _context.SaveChanges();
                result = staff_attendence.ID;
            }
            return result;
        }

        public Int64 UpdateAttendence(STAFF_ATTENDENCE staff_attendence)
        {
            Int64 result = -1;
            if (staff_attendence != null)
            {
                _context.Entry(staff_attendence).State = EntityState.Modified;
                _context.SaveChanges();
                result = staff_attendence.ID;
            }
            return result;
        }

        public void DeleteAttendence(Int64 id)
        {
            STAFF_ATTENDENCE attendence = _context.STAFF_ATTENDENCE.Find(id);
            _context.STAFF_ATTENDENCE.Remove(attendence);
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