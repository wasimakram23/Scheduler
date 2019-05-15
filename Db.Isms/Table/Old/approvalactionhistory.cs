using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    public class approvalactionhistory
    {
        public int ApprovalActionHistoryID { get; set; }                /*id*/
        public int TestSimReqHeaderID { get; set; }
        public int WorkflowLineID { get; set; }
        public string RequisitionNo { get; set; }
        public string ActionNo { get; set; }
        public int EmployeeID { get; set; }
        public int UserGroupID { get; set; }
        public int Sequence { get; set; }
        public string ActionStatus { get; set; }
        public Nullable<System.DateTime> NewDateExtension { get; set; }
        public Nullable<double> NewCreditExtension { get; set; }
        public Nullable<System.DateTime> TCExtensionDate { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> DeactivationDate { get; set; }
        public Nullable<System.DateTime> SurrenderDate { get; set; }
        public Nullable<System.DateTime> DamageLostDate { get; set; }
        public Nullable<System.DateTime> TransferLostDate { get; set; }
        public Nullable<System.DateTime> TaskCreationDate { get; set; }
        public Nullable<System.DateTime> TaskCompletionDate { get; set; }
        public string Phase { get; set; }
        public string Comments { get; set; }
    }
}
