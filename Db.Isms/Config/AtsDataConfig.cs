using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class AtsDataConfig:EntityTypeConfiguration<atsdata>
    {
        public AtsDataConfig()
        {
            ToTable("atsdata");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .HasColumnName("ATSID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.ActionNo)
                .HasColumnName("ActionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.ATSTicketNo)
                .HasColumnName("ATSTicketNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.FileName)
                .HasColumnName("FileName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);
            Property(x =>x.FilePath)
                .HasColumnName("FilePath")
                .HasColumnType("VARCHAR")
                .HasMaxLength(500);
            Property(x =>x.HasActivated)
                .HasColumnName("HasActivated")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.KITNumber)
                .HasColumnName("KITNumber")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.MSISDN)
                .HasColumnName("MSISDN")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.RequisitionNo)
                .HasColumnName("RequisitionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
