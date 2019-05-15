using Db.Isms.Contract;
using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    /*DbChange: need column order*/
    public  class newtestsimrequisitionline : IOwn, ITimeLimit
    {
        public newtestsimrequisitionline()
        {
            //this.msisdnorkitdetails = new HashSet<msisdnorkitdetail>();
            //this.msisdnorkitdetailshistories = new HashSet<msisdnorkitdetailshistory>();
        }
    
        public int ID { get; set; }                         /*Pk*/
        public int TestSimReqHeaderID { get; set; }
        public int ProductID { get; set; }
        public int LineNo { get; set; }
        public double CreditLimit { get; set; }
        public double Quantity { get; set; }
        public string KITType { get; set; }
        public Nullable<int> IMSITypeID { get; set; }
        public string ConnectionType { get; set; }
        public string IsDelivered { get; set; }
        public bool IsActive { get; set; }
        public string Comments { get; set; }
        public Nullable<double> AssignQuantity { get; set; }
        public Nullable<double> AssignCreditLimit { get; set; }

        public DateTime? TimeLimitFrom { get; set; }
        public DateTime? TimeLimitTo { get; set; }
        public string OwnBy { get; set; }
        public int SimRequestStage { get; set; }

        //public virtual imsitype imsitype { get; set; }
        //public virtual ICollection<msisdnorkitdetail> msisdnorkitdetails { get; set; }
        //public virtual ICollection<msisdnorkitdetailshistory> msisdnorkitdetailshistories { get; set; }
        //public virtual newtestsimrequisitionheader newtestsimrequisitionheader { get; set; }
        //public virtual product product { get; set; }
    }
}
