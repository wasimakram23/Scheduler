﻿using Db.Isms.Table.Old;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Db.Isms.Config
{
    internal class WfHeaderConfig:EntityTypeConfiguration<wfheader>
    {
        public WfHeaderConfig()
        {
            ToTable("wfheader");

            HasKey(x => x.WorkflowHeaderID);
            Property(x =>x.WorkflowHeaderID)
                .HasColumnName("WorkflowHeaderID")
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
            Property(x =>x.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            Property(x =>x.Type)
                .HasColumnName("Type")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            Property(x =>x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            Property(x =>x.UpdatedDate)
                .HasColumnName("UpdatedDate");
        }
    }
}
