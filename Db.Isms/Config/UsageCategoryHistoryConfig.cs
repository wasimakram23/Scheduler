using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class UsageCategoryHistoryConfig:EntityTypeConfiguration<usagecategoryhistory>
    {
        public UsageCategoryHistoryConfig()
        {
            ToTable("usagecategoryhistory");

            HasKey(x => x.ID);
            Property(x =>x.ID)
                .HasColumnName("UsageCategoryHistoryID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.TaskCreation)
                .HasColumnName("TaskCreation");
            Property(x =>x.TestSimReqHeaderID)
                .HasColumnName("TestSimReqHeaderID");
            Property(x =>x.UsageCategoryID)
                .HasColumnName("UsageCategoryID");
        }
    }
}
