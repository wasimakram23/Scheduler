using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class DepartmentConfig : EntityTypeConfiguration<department>
    {
        public DepartmentConfig()
        {
            ToTable("department");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("DepartmentID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DepartmentName)
                .HasColumnName("DepartmentName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            Property(x => x.CreatedBY)
                .HasColumnName("CreatedBY")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x => x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x => x.DivisionID)
                .HasColumnName("DivisionID");
            Property(x => x.updatedBY)
                .HasColumnName("updatedBY")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x => x.UpdatedDate)
                .HasColumnName("UpdatedDate");
        } 
    }
}
