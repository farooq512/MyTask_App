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
    
    public partial class PROJECT
    {
        public PROJECT()
        {
            this.AU_TASK = new HashSet<AU_TASK>();
        }
    
        public int PROJECT_ID { get; set; }
        public string PROJECT_TITLE { get; set; }
        public string PROJECT_DESCRIPTION { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        public virtual ICollection<AU_TASK> AU_TASK { get; set; }
    }
}
