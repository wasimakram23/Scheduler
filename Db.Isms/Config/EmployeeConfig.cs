using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class EmployeeConfig:EntityTypeConfiguration<employee>
    {
        public EmployeeConfig()
        {
            ToTable("employee");

            HasKey(x => x.EmployeeID);
            Property(x =>x.EmployeeID)
                .HasColumnName("EmployeeID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x =>x.Active)
                .HasColumnName("Active");
            Property(x =>x.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            Property(x =>x.CreatedDate)
                .HasColumnName("CreatedDate");
            Property(x =>x.Department)
                .HasColumnName("Department")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.DepartmentHODID)
                .HasColumnName("DepartmentHODID");
            Property(x =>x.DepartmentID)
                .HasColumnName("DepartmentID");
            Property(x =>x.Designation)
                .HasColumnName("Designation")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.Division)
                .HasColumnName("Division")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            Property(x =>x.DivisionID)
                .HasColumnName("DivisionID");
            Property(x =>x.DomainID)
                .HasColumnName("DomainID")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.EmpCode)
                .HasColumnName("EmpCode")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();
            Property(x =>x.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();
            Property(x =>x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.OrganizationID)
                .HasColumnName("OrganizationID");
            Property(x =>x.Type)
                .HasColumnName("Type")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x =>x.UpdatedDate)
                .HasColumnName("UpdatedDate");
            Property(x =>x.UserGroupID)
                .HasColumnName("UserGroupID");

        }
    }
}
