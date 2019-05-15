using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    public class employeevsgroup
    {
        public int UserVSGroupID { get; set; }              /*Id*/
        public int EmployeeID { get; set; }
        public int GroupID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual employee employee { get; set; }
        public virtual usergroup usergroup { get; set; }
    }
}
