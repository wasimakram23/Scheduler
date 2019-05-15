using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
   
    
    public  class organization
    {
       
        public organization()
        {
            //this.employees = new HashSet<employee>();
            //this.employees1 = new HashSet<employee>();
        }
    
        public int ID { get; set; }
        public Nullable<int> DivisionID { get; set; }
        public int DepartmentID { get; set; }
        public int SectionID { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<employee> employees { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<employee> employees1 { get; set; }
    }
}
