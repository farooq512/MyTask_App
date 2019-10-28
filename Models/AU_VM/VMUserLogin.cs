using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AU_Tasks_App.Models.AU_VM
{
    public class VMUserLogin
    {
        [Key]
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
    }
}