using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    
    public  class location
    {
        public location()
        {
            //this.newtestsimrequisitionheaders = new HashSet<newtestsimrequisitionheader>();
        }
    
        public int LocationID { get; set; }                 /*Id*/
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //    public virtual ICollection<newtestsimrequisitionheader> newtestsimrequisitionheaders { get; set; }
    }
}
