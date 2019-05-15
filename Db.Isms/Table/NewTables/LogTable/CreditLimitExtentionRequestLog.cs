using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISmsNewModels.Table
{
    public class CreditLimitExtentionRequestLog
    {
        public long LogId { get; set; }
        public CreditLimitExtentionRequest LogFor { get; set; }
        public DateTime? LogDateTime { get; set; }


        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public string RequestCode { get; set; }
        public int Status { get; set; }
    }
}
