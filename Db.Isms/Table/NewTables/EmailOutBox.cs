using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Db.Isms.Contract;

namespace Db.Isms.Table
{
    [Table("EmailOutBox")]
    public class EmailOutBox : ITable
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public DateTime? BatchDateTime { get; set; }            /*to track batch process, we are not using any log table thats why*/
        public int TryCount { get; set; }
        public DateTime? DeliveryDateTime { get; set; }         /*null if not send yet*/

        public int DeliveryStatus { get; set; }
        public int EmailType { get; set; }
        public string Remarks { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
