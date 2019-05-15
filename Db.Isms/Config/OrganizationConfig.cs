using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class OrganizationConfig:EntityTypeConfiguration<organization>
    {
        public OrganizationConfig()
        {
            ToTable("organization");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .HasColumnName("OrganizationID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x =>x.DepartmentID)
                .HasColumnName("DepartmentID");
            Property(x =>x.DivisionID)
                .HasColumnName("DivisionID");
            Property(x =>x.SectionID)
                .HasColumnName("SectionID");
            Property(x =>x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x =>x.UpdatedDate)
                .HasColumnName("UpdatedDate");
        }
    }
}
