using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    
    public  class usagecategory
    {
        
        public usagecategory()
        {
           // this.usagecategoryhistories = new HashSet<usagecategoryhistory>();
        }
    
        public int UsageCategoryID { get; set; }        /*Id*/
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        
        //public virtual ICollection<usagecategoryhistory> usagecategoryhistories { get; set; }
    }
}
