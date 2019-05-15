using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
       
    public  class requisitiontype
    {
        
        public requisitiontype()
        {
            //this.newtestsimrequisitionheaders = new HashSet<newtestsimrequisitionheader>();
        }
    
        public int RequisitionTypeID { get; set; }          /*Id*/
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        
        //public virtual ICollection<newtestsimrequisitionheader> newtestsimrequisitionheaders { get; set; }
    }
}
