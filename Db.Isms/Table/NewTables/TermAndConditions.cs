using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db.Isms.Contract;

namespace ISmsNewModels.Table
{
    public class TermAndConditions : ITable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PdfLocation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int IsActive { get; set; }

    }
}
