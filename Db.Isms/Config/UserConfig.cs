using Db.Isms.Table;
using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class UserConfig:EntityTypeConfiguration<user>
    {
        public UserConfig()
        {
            ToTable("user");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(250)
                .IsRequired();
            Property(x =>x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("VARCHAR")
                .HasMaxLength(250)
                .IsRequired();
            Property(x => x.EmpNo)
                .HasColumnName("EMP_NO");
        }
    }
}
