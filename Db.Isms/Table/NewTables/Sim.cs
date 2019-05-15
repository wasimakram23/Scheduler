using Db.Isms.Contract;
using ISmsNewModels.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ISmsNewModels.Model
{
    [Table("Sim")]
    public class Sim : ISim //, IHasLog<SimLog>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public int NewSimRequestId { get; set; }            /*Fk RequisitionRequest id*/ /*DbChange: need index, change column name*/

        /*ssm =>*/
        public string ImsiNo { get; set; }                  /*ssm Pk*/
        public string IccidNo { get; set; }
        public string MobileNo { get; set; }                /*DbChange: need index*/
        public string ImsiType { get; set; }
        public string ProductCode { get; set; }
        public string ItemCode { get; set; }
        public string SkitNo { get; set; }
        /*ssm =>*/

        [Required]
        public DateTime? TimeLimitFrom { get; set; }
        [Required]
        public DateTime? TimeLimitTo { get; set; }
        [Required]
        public double? CreditLimit { get; set; }

        public string OwnBy { get; set; }                       /*DbChange: need index*/
        public int LastSimOperation { get; set; }               /*DbChange: need index*/
        public bool IsActive { get; set; }                      /*DbChange: need index*/
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        //public virtual List<SimLog> Logs { get; set; }
        //public virtual List<ActivationRequestSim> ActivationRequestSims { get; set; }
        //public virtual List<ActivationRequestSimLog> ActivationRequestSimLogs { get; set; }
        //public virtual List<CreditLimitExtentionRequestSim> CreditLimitExtentionRequestSims { get; set; }
        //public virtual List<CreditLimitExtentionRequestSimLog> CreditLimitExtentionRequestSimLogs { get; set; }
        //public virtual List<TimeLimitExtentionRequestSim> TimeLimitExtentionRequestSims { get; set; }
        //public virtual List<TimeLimitExtentionRequestSimLog> TimeLimitExtentionRequestSimLogs { get; set; }
    }
}
