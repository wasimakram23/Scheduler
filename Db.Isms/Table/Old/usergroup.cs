using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    
    public class usergroup
    {
        public usergroup()
        {
        //    this.employees = new HashSet<employee>();
        //    this.wflines = new HashSet<wfline>();
        //    this.employeevsgroups = new HashSet<employeevsgroup>();
        }
    
        public int UserGroupID { get; set; }            /*id*/
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string EmailID { get; set; }

        //public virtual ICollection<employee> employees { get; set; }
        public virtual ICollection<employeevsgroup> employeevsgroups { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<wfline> wflines { get; set; }
    }
}
