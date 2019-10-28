//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AU_Tasks_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AU_TASK
    {
        public AU_TASK()
        {
            this.TASK_DETAIL = new HashSet<TASK_DETAIL>();
            this.TASK_RELEASE_NOTE = new HashSet<TASK_RELEASE_NOTE>();
        }
    
        public int TASK_ID { get; set; }
        public string TASK_TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> STARTING_DATE { get; set; }
        public Nullable<System.DateTime> ENDING_DATE { get; set; }
        public Nullable<int> ASSIGN_TO { get; set; }
        public Nullable<int> ASSIGN_FROM { get; set; }
        public string TASK_STATUS { get; set; }
        public Nullable<int> WORK_BAR_STATUS { get; set; }
        public Nullable<System.DateTime> CLOSING_DATE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public Nullable<int> PROJECT_ID { get; set; }
    
        public virtual PROJECT PROJECT { get; set; }
        public virtual USERS USERS { get; set; }
        public virtual ICollection<TASK_DETAIL> TASK_DETAIL { get; set; }
        public virtual ICollection<TASK_RELEASE_NOTE> TASK_RELEASE_NOTE { get; set; }
    }
}
