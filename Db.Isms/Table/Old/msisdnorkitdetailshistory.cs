using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{

    public class msisdnorkitdetailshistory
    {
        public int ID { get; set; }
        public int TestSimReqLineID { get; set; }
        public int ProductID { get; set; }
        public string RequisitionNo { get; set; }
        public string KITType { get; set; }
        public string MSISDN { get; set; }
        public string KITNumber { get; set; }
        public string ActionNo { get; set; }
        public System.DateTime ActionDate { get; set; }
        public string SIMStatus { get; set; }
        public string ActionStatus { get; set; }
        public int CreatorEmpID { get; set; }
    
        //public virtual employee employee { get; set; }
        //public virtual product product { get; set; }
        //public virtual newtestsimrequisitionline newtestsimrequisitionline { get; set; }
    }
}
