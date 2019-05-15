using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class LocationConfig:EntityTypeConfiguration<location>
    {
        public LocationConfig()
        {
            ToTable("location");

            HasKey(x => x.LocationID);
            Property(x => x.LocationID)
                .HasColumnName("LocationID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x => x.Active)
                .HasColumnName("Active");
            Property(x => x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x => x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x => x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x => x.UpdatedDate)
                .HasColumnName("UpdatedDate");
        }
    }
}
