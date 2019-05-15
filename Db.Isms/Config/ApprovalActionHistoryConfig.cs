using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class ApprovalActionHistoryConfig:EntityTypeConfiguration<approvalactionhistory>
    {
        public ApprovalActionHistoryConfig()
        {
            ToTable("approvalactionhistory");
            HasKey(x => x.ApprovalActionHistoryID);
            Property(x => x.ApprovalActionHistoryID)
                .HasColumnName("ApprovalActionHistoryID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ActionNo)
                .HasColumnName("ActionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x => x.ActionStatus)
                .HasColumnName("ActionStatus")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x => x.Comments)
                .HasColumnName("Comments")
                .HasColumnType("VARCHAR")
                .HasMaxLength(2000);
            Property(x => x.DamageLostDate)
                .HasColumnName("DamageLostDate");
            Property(x => x.DeactivationDate)
                .HasColumnName("DeactivationDate");
            Property(x => x.EmployeeID)
                .HasColumnName("EmployeeID");
            Property(x => x.NewCreditExtension)
                .HasColumnName("NewCreditExtension");
            Property(x => x.NewDateExtension)
                .HasColumnName("NewDateExtension");
            Property(x => x.Phase)
                .HasColumnName("Phase")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x => x.RequisitionNo)
                .HasColumnName("RequisitionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x => x.Sequence)
                .HasColumnName("Sequence");
            Property(x => x.SurrenderDate)
                .HasColumnName("SurrenderDate");
            Property(x => x.TaskCompletionDate)
                .HasColumnName("TaskCompletionDate");
            Property(x => x.TaskCreationDate)
                .HasColumnName("TaskCreationDate");
            Property(x => x.TCExtensionDate)
                .HasColumnName("TCExtensionDate");
            Property(x => x.TestSimReqHeaderID)
                .HasColumnName("TestSimReqHeaderID");
            Property(x => x.TransferLostDate)
                .HasColumnName("TransferLostDate");
            Property(x => x.Type)
                .HasColumnName("Type")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            Property(x => x.UserGroupID)
                .HasColumnName("UserGroupID");
            Property(x => x.WorkflowLineID)
                .HasColumnName("WorkflowLineID");
            
        }
    }
}
