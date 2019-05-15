using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class WfLineConfig:EntityTypeConfiguration<wfline>
    {
        public WfLineConfig()
        {
            ToTable("wfline");

            HasKey(x => x.WorkflowLineID);
            Property(x => x.WorkflowLineID)
                .HasColumnName("WorkflowLineID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x =>x.Active)
                .HasColumnName("Active");
            Property(x =>x.ActivityName)
                .HasColumnName("ActivityName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x =>x.CurrentSequence)
                .HasColumnName("CurrentSequence");
            Property(x =>x.Event)
                .HasColumnName("Event")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.EventID)
                .HasColumnName("EventID");
            Property(x =>x.NextSequence)
                .HasColumnName("NextSequence");
            Property(x =>x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x =>x.UpdatedDate)
                .HasColumnName("UpdatedDate");
            Property(x =>x.UserGroupID)
                .HasColumnName("UserGroupID");
            Property(x => x.WorkflowHeaderID)
                .HasColumnName("WorkflowHeaderID");

            //ALTER TABLE `wflines`
            //ADD CONSTRAINT `FK_ugFk` 
            //FOREIGN KEY(`UserGroupID`) REFERENCES `usergroups` (`UserGroupID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
            //HasRequired(x => x.usergroup)
            //    .WithMany(p => p.wflines)
            //    .HasForeignKey(k => k.UserGroupID)
            //    .WillCascadeOnDelete(false);

            //ALTER TABLE `wflines`
            //ADD CONSTRAINT `FK_wfheaderfk` 
            //FOREIGN KEY(`WorkflowHeaderID`) REFERENCES `wfheaders` (`WorkflowHeaderID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
            //HasRequired(x => x.wfheader)
            //    .WithMany(p => p.wflines)
            //    .HasForeignKey(k => k.WorkflowHeaderID)
            //    .WillCascadeOnDelete(false);
        }
    }
}
