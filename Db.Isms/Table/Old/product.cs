using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
   
    
    public  class product
    {
        public product()
        {
        //    this.msisdnorkitdetails = new HashSet<msisdnorkitdetail>();
        //    this.msisdnorkitdetailshistories = new HashSet<msisdnorkitdetailshistory>();
        //    this.newtestsimrequisitionlines = new HashSet<newtestsimrequisitionline>();
        }
    
        public int ProductID { get; set; }          /*Id*/
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<msisdnorkitdetail> msisdnorkitdetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<msisdnorkitdetailshistory> msisdnorkitdetailshistories { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<newtestsimrequisitionline> newtestsimrequisitionlines { get; set; }
    }
}
