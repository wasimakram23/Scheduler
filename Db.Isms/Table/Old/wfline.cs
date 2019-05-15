using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    public class wfline
    {
        public int WorkflowLineID { get; set; }             /*id*/
        public int WorkflowHeaderID { get; set; }
        public int UserGroupID { get; set; }
        public int CurrentSequence { get; set; }
        public int NextSequence { get; set; }
        public string ActivityName { get; set; }
        public string Event { get; set; }
        public Nullable<int> EventID { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        //public virtual usergroup usergroup { get; set; }
        //public virtual wfheader wfheader { get; set; }
    }
}
