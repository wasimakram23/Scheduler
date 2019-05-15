using ISmsNewModels.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Isms.Config
{
    internal class TermsAndConditionsConfig : EntityTypeConfiguration<TermAndConditions>
    {
        public TermsAndConditionsConfig()
        {
            ToTable("TermAndConditions");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name)
                .HasColumnName("Name");
            Property(x => x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x => x.CreatedDateTime)
                .HasColumnName("CreatedDateTime");
            Property(x => x.PdfLocation)
                .HasColumnName("PdfLocation")
                .HasColumnType("VARCHAR")
                .HasMaxLength(500);
            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("Int");
            Property(x => x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x => x.UpdatedDateTime)
                .HasColumnName("UpdatedDateTime");
        }
    }
}
