
using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class DivisionConfig : EntityTypeConfiguration<division>
    {
        public DivisionConfig()
        {

            ToTable("division");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("DivisionID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);  /*todo: check in db, how PK is working*/

            Property(e => e.DepartmentID)
                .HasColumnName("DepartmentID");
            Property(e => e.DivisionName)
                .HasColumnName("DivisionName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            Property(e => e.CreatedBY)
                .HasColumnName("CreatedBY")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(e => e.updatedBY)
                .HasColumnName("updatedBY")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(e => e.UpdatedDate)
                .HasColumnName("UpdatedDate");

            //Property(e => e.CommissionAmount)
            //    .HasColumnName("COMMISSION_AMOUNT")
            //    .HasColumnType("NUMBER");
        }
    }
}