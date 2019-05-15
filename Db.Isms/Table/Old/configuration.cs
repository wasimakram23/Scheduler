using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    public class configuration
    {
        public int ID { get; set; }
        public string SendDataToATS { get; set; }
        public string SendEmail { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
