using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    public  class usagecategoryhistory
    {
        public int ID { get; set; }
        public int TestSimReqHeaderID { get; set; }
        public int UsageCategoryID { get; set; }
        public System.DateTime TaskCreation { get; set; }
    
        //public virtual newtestsimrequisitionheader newtestsimrequisitionheader { get; set; }
        //public virtual usagecategory usagecategory { get; set; }
    }
}
