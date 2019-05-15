using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISmsNewModels.Table
{
    public class TimeLimitExtentionRequestSimLog
    {
        public long LogId { get; set; }
        public TimeLimitExtentionRequestSim LogFor { get; set; }
        public DateTime? LogDateTime { get; set; }


        public int TimeLimitExtentionRequestId { get; set; }       /*Fk RequisitionRequest id*/

        public int RequisitionRequestId { get; set; }               /*Fk RequisitionRequest id*/

        /*ssm =>*/
        public string ImsiNo { get; set; }                  /*ssm Pk*/
        public string IccidNo { get; set; }
        public string MobileNo { get; set; }
        public string ImsiType { get; set; }
        public string ProductCode { get; set; }
        public string ItemCode { get; set; }
        public string SkitNo { get; set; }
        /*ssm =>*/
        public int CurrentState { get; set; }
        public bool IsActive { get; set; }

        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }


    }
}
