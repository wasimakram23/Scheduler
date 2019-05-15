using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class MsisdnkitDetailHistoryConfig:EntityTypeConfiguration<msisdnorkitdetailshistory>
    {
        public MsisdnkitDetailHistoryConfig()
        {
            ToTable("msisdnorkitdetailshistory");

            HasKey(x => x.ID);

            Property(x =>x.ID)
                .HasColumnName("MSISDNORKITDetailsHistoryID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.ActionDate)
                .HasColumnName("ActionDate");
            Property(x =>x.ActionNo)
                .HasColumnName("ActionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.ActionStatus)
                .HasColumnName("ActionStatus")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.CreatorEmpID)
                .HasColumnName("CreatorEmpID");
            Property(x =>x.KITNumber)
                .HasColumnName("KITNumber")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.KITType)
                .HasColumnName("KITType")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.MSISDN)
                .HasColumnName("MSISDN")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.ProductID)
                .HasColumnName("ProductID");
            Property(x =>x.RequisitionNo)
                .HasColumnName("RequisitionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x => x.SIMStatus)
                .HasColumnName("SIMStatus")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.TestSimReqLineID)
                .HasColumnName("TestSimReqLineID");

        }
    }
}
