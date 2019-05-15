using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    public partial class msisdnorkitdetail
    {
        public int ID { get; set; }
        public int TestSimReqLineID { get; set; }
        public int ProductID { get; set; }
        public string RequisitionNo { get; set; }
        public int KITType { get; set; }
        public string MSISDN { get; set; }
        public string KITNumber { get; set; }
        public int SIMOwnerID { get; set; }
        public string RegistrationStatus { get; set; }
        public string SIMStatus { get; set; }
        public Nullable<System.DateTime> LastActivationDate { get; set; }
        public int CreatorEmpID { get; set; }
        public Nullable<System.DateTime> LastDeactivationDate { get; set; }
        public Nullable<System.DateTime> LastTimeExtensionDate { get; set; }
        public Nullable<System.DateTime> LastSurrenderDate { get; set; }
        public Nullable<System.DateTime> LastDamageLostDate { get; set; }
        public Nullable<System.DateTime> LastTransferHandoverDate { get; set; }
    
        //public virtual employee employee { get; set; }
        //public virtual employee employee1 { get; set; }
        //public virtual product product { get; set; }
        //public virtual newtestsimrequisitionline newtestsimrequisitionline { get; set; }
    }
}
