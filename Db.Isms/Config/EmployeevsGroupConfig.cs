using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class EmployeevsGroupConfig:EntityTypeConfiguration<employeevsgroup>
    {
        public EmployeevsGroupConfig()
        {
            ToTable("employeevsgroup");

            HasKey(x => x.UserVSGroupID);
            Property(x =>x.UserVSGroupID)
                .HasColumnName("UserVSGroupID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            Property(x =>x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x =>x.GroupID)
                .HasColumnName("GroupID");
            Property(x =>x.EmployeeID)
                .HasColumnName("EmployeeID");
            Property(x =>x.IsActive)
                .HasColumnName("IsActive");
            Property(x =>x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            Property(x =>x.UpdatedDate)
                .HasColumnName("UpdatedDate");

            HasRequired(x => x.employee)
                .WithMany(p => p.employeevsgroups)
                .HasForeignKey(k => k.EmployeeID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.usergroup)
                .WithMany(p => p.employeevsgroups)
                .HasForeignKey(k => k.GroupID)
                .WillCascadeOnDelete(false);
        }
    }
}
