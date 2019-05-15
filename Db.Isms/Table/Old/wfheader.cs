using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{   
    
    public class wfheader
    {
        public wfheader()
        {
            //this.wflines = new HashSet<wfline>();
        }
    
        public int WorkflowHeaderID { get; set; }               /*Id*/
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
   
        //public virtual ICollection<wfline> wflines { get; set; }
    }
}
