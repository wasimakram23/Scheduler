using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class NewTestSimRequisitionLineConfig:EntityTypeConfiguration<newtestsimrequisitionline>
    {
        public NewTestSimRequisitionLineConfig()
        {
            ToTable("newtestsimrequisitionline");

            HasKey(x => x.ID);
            Property(x =>x.ID)
                .HasColumnName("TestSimReqLineID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.TestSimReqHeaderID)
                .HasColumnName("TestSimReqHeaderID");
            Property(x =>x.AssignCreditLimit)
                .HasColumnName("AssignCreditLimit");
            Property(x =>x.AssignQuantity)
                .HasColumnName("AssignQuantity");
            Property(x =>x.Comments)
                .HasColumnName("Comments")
                .HasColumnType("VARCHAR")
                .HasMaxLength(1000);
            Property(x =>x.ConnectionType)
                .HasColumnName("ConnectionType")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.CreditLimit)
                .HasColumnName("CreditLimit");
            Property(x =>x.IMSITypeID)
                .HasColumnName("IMSITypeID");
            Property(x =>x.IsActive)
                .HasColumnName("IsActive");
            Property(x =>x.IsDelivered)
                .HasColumnName("IsDelivered")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x =>x.KITType)
                .HasColumnName("KITType")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.LineNo)
                .HasColumnName("LineNo");
            Property(x =>x.ProductID)
                .HasColumnName("ProductID");
            Property(x =>x.Quantity)
                .HasColumnName("Quantity");

            Property(x => x.TimeLimitFrom)
                .HasColumnName("TimeLimitFrom")
                .IsRequired();
            Property(x => x.TimeLimitTo)
                .HasColumnName("TimeLimitTo")
                .IsRequired();
            Property(x => x.OwnBy)
                .HasColumnName("OwnBy")
                .HasColumnType("VARCHAR");
            Property(x => x.SimRequestStage)
                .HasColumnName("SimRequestStage");
        }
    }
}
