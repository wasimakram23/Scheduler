using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class NewTestSimRequisitionHeaderConfig:EntityTypeConfiguration<newtestsimrequisitionheader>
    {
        public NewTestSimRequisitionHeaderConfig()
        {
            ToTable("newtestsimrequisitionheader");

            HasKey(x => x.TestSimReqHeaderID);
            Property(x =>x.TestSimReqHeaderID)
                .HasColumnName("TestSimReqHeaderID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.LocationID)
                .HasColumnName("LocationID");
            Property(x =>x.NotificationTo)
                .HasColumnName("NotificationTo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);
            Property(x =>x.PurposeDetails)
                .HasColumnName("PurposeDetails")
                .HasColumnType("VARCHAR")
                .HasMaxLength(1000)
                .IsRequired();
            Property(x =>x.PurposeTypeID)
                .HasColumnName("PurposeTypeID");
            Property(x =>x.RequisitionDate)
                .HasColumnName("RequisitionDate");
            Property(x =>x.RequisitionNo)
                .HasColumnName("RequisitionNo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.RequisitionTypeID)
                .HasColumnName("RequisitionTypeID");
            Property(x =>x.OwnBy)
                .HasColumnName("TaskCreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.TestEndDate)
                .HasColumnName("TestEndDate");
            Property(x =>x.TestStartDate)
                .HasColumnName("TestStartDate");

        }
    }
}
