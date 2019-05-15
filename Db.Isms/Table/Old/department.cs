//------------------------------------------------------------------------------
using Db.Isms.Table.Old;
using System;
using System.Collections.Generic;
namespace Db.Isms.Table.Old
{
    public class department
    {
        public department()
        {
        }
    
        public int Id { get; set; }
        public int DivisionID { get; set; }
        public string DepartmentName { get; set; }
        public string CreatedBY { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string updatedBY { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        //public virtual ICollection<employee> employees { get; set; }
        //public virtual department division { get; set; }
    }
}
