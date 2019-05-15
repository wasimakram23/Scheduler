using Db.Isms.Contract;
using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{   
    public class newtestsimrequisitionheader : IOwn
    {
        public newtestsimrequisitionheader()
        {
            //this.usagecategoryhistories = new HashSet<usagecategoryhistory>();
            //this.newtestsimrequisitionlines = new HashSet<newtestsimrequisitionline>();
        }
    
        public int TestSimReqHeaderID { get; set; }         /*Id*/
        public int RequisitionTypeID { get; set; }
        public int PurposeTypeID { get; set; }
        public int LocationID { get; set; }
        public string RequisitionNo { get; set; }           /*todo: need to create from backend*/
        public System.DateTime RequisitionDate { get; set; }
        public string PurposeDetails { get; set; }
        public System.DateTime TestStartDate { get; set; }
        public System.DateTime TestEndDate { get; set; }
        public string NotificationTo { get; set; }

        /*DbChange: need to change to OwnBy, */
        public string OwnBy { get; set; }
    
        //public virtual location location { get; set; }
        //public virtual ICollection<usagecategoryhistory> usagecategoryhistories { get; set; }
        //public virtual purposetype purposetype { get; set; }
        //public virtual requisitiontype requisitiontype { get; set; }
        //public virtual ICollection<newtestsimrequisitionline> newtestsimrequisitionlines { get; set; }
    }
}
