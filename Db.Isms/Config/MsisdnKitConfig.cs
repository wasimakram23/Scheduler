using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class MsisdnKitConfig:EntityTypeConfiguration<msisdnorkitdetail>
    {
        public MsisdnKitConfig()
        {
            ToTable("msisdnorkitdetails");

            HasKey(x => x.ID);
            Property(x =>x.ID)
                .HasColumnName("MSISDNORKITDetailsID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.CreatorEmpID)
                .HasColumnName("CreatorEmpID");
            Property(x =>x.KITNumber)
                .HasColumnName("KITNumber")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.KITType)
                .HasColumnName("KITType");
            Property(x =>x.LastActivationDate)
                .HasColumnName("LastActivationDate");
            Property(x =>x.LastDamageLostDate)
                .HasColumnName("LastDamageLostDate");
            Property(x =>x.LastDeactivationDate)
                .HasColumnName("LastDeactivationDate");
            Property(x =>x.LastSurrenderDate)
                .HasColumnName("LastSurrenderDate");
            Property(x =>x.LastTimeExtensionDate)
                .HasColumnName("LastTimeExtensionDate");
            Property(x =>x.LastTransferHandoverDate)
                .HasColumnName("LastTransferHandoverDate");
            Property(x =>x.MSISDN)
                .HasColumnName("MSISDN")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.ProductID)
                .HasColumnName("ProductID");
            Property(x =>x.RegistrationStatus)
                .HasColumnName("RegistrationStatus")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.RequisitionNo)
                .HasColumnName("RequisitionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.SIMOwnerID)
                .HasColumnName("SIMOwnerID");
            Property(x =>x.SIMStatus)
                .HasColumnName("SIMStatus")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.TestSimReqLineID)
                .HasColumnName("TestSimReqLineID");

        }
    }
}
