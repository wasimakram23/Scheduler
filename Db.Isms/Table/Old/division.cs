using System;
using System.Collections.Generic;


namespace Db.Isms.Table.Old
{    
    public class division
    {  
        public int Id { get; set; }
        public int DepartmentID { get; set; }
        public string DivisionName { get; set; }
        public string CreatedBY { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public string updatedBY { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
    
        //public virtual department department { get; set; }
        //public virtual ICollection<employee> employees { get; set; }
    }
}
