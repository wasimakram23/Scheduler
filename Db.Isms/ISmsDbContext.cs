/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : Isms db
*/

using Db.Isms.Config;
using Db.Isms.Table.Old;
using Db.Isms.Table;
using MySql.Data.Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ISmsNewModels.Table;
using ISmsNewModels.Model;

namespace Db.Isms
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public abstract class ISmsDbContext : DbContext, IISmsDbContext
    {
        protected ISmsDbContext(string connectionStringName) : base(connectionStringName)
        {

        }
        public virtual DbSet<user> users { get; set; }

        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<division> divisions { get; set; }
        public virtual DbSet<usergroup> usergroups { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<approvalactionhistory> approvalactionhistories { get; set; }
        public virtual DbSet<organization> organizations { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<configuration> configurations { get; set; }
        public virtual DbSet<purposetype> purposetypes { get; set; }
        public virtual DbSet<employeevsgroup> employeevsgroups { get; set; }
        public virtual DbSet<wfheader> wfheaders { get; set; }
        public virtual DbSet<wfline> wflines { get; set; }
        public virtual DbSet<usagecategory> usagecategories { get; set; }
        public virtual DbSet<atsdata> atsdatas { get; set; }
        public virtual DbSet<imsitype> imsitypes { get; set; }
        public virtual DbSet<requisitiontype> requisitiontypes { get; set; }
        public virtual DbSet<msisdnorkitdetail> msisdnorkitdetails { get; set; }
        public virtual DbSet<newtestsimrequisitionheader> newtestsimrequisitionheaders { get; set; }
        public virtual DbSet<newtestsimrequisitionline> newtestsimrequisitionlines { get; set; }
        public virtual DbSet<msisdnorkitdetailshistory> msisdnorkitdetailshistories { get; set; }
        public virtual DbSet<usagecategoryhistory> usagecategoryhistories { get; set; }
        public virtual DbSet<TermAndConditions> termsandconditionss { get; set; }



        //public virtual DbSet<TermAndConditions> TermAndCondition { get; set; }
        public virtual IDbSet<EmailOutBox> EmailOutBox { get; set; }

        public virtual DbSet<Sim> Sim { get; set; }
        public virtual DbSet<ActivationRequest> ActivationRequest { get; set; }
        public virtual DbSet<ActivationRequestSim> ActivationRequestSim { get; set; }


        /*log*/
        public virtual DbSet<SimLog> SimLog { get; set; }
        public virtual DbSet<ActivationRequestLog> ActivationRequestLog { get; set; }
        public virtual DbSet<ActivationRequestSimLog> ActivationRequestSimLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new DepartmentConfig());
            modelBuilder.Configurations.Add(new DivisionConfig());
            modelBuilder.Configurations.Add(new UserGroupConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new OrganizationConfig());
            modelBuilder.Configurations.Add(new LocationConfig());
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new EmployeevsGroupConfig());
            modelBuilder.Configurations.Add(new ConfigurationConfig());
            modelBuilder.Configurations.Add(new PurposeTypeConfig());
            modelBuilder.Configurations.Add(new WfHeaderConfig());
            modelBuilder.Configurations.Add(new WfLineConfig());
            modelBuilder.Configurations.Add(new UsageCatagoryConfig());
            modelBuilder.Configurations.Add(new AtsDataConfig());
            modelBuilder.Configurations.Add(new ImsiTypeConfig());
            modelBuilder.Configurations.Add(new RequisitionTypeConfig());
            modelBuilder.Configurations.Add(new MsisdnKitConfig());
            modelBuilder.Configurations.Add(new NewTestSimRequisitionHeaderConfig());
            modelBuilder.Configurations.Add(new MsisdnkitDetailHistoryConfig());
            modelBuilder.Configurations.Add(new NewTestSimRequisitionLineConfig());
            modelBuilder.Configurations.Add(new UsageCategoryHistoryConfig());
            modelBuilder.Configurations.Add(new ApprovalActionHistoryConfig());
            modelBuilder.Configurations.Add(new TermsAndConditionsConfig());
            base.OnModelCreating(modelBuilder);
        }  
    }


    public interface IISmsDbContext
    {
        DbSet<user> users { get; set; }

        DbSet<department> departments { get; set; }
        DbSet<division> divisions { get; set; }
        DbSet<usergroup> usergroups { get; set; }
        DbSet<product> products { get; set; }
        DbSet<approvalactionhistory> approvalactionhistories { get; set; }
        DbSet<organization> organizations { get; set; }
        DbSet<location> locations { get; set; }
        DbSet<employee> employees { get; set; }
        DbSet<configuration> configurations { get; set; }
        DbSet<purposetype> purposetypes { get; set; }
        DbSet<employeevsgroup> employeevsgroups { get; set; }
        DbSet<wfheader> wfheaders { get; set; }
        DbSet<wfline> wflines { get; set; }
        DbSet<usagecategory> usagecategories { get; set; }
        DbSet<atsdata> atsdatas { get; set; }
        DbSet<imsitype> imsitypes { get; set; }
        DbSet<requisitiontype> requisitiontypes { get; set; }
        DbSet<msisdnorkitdetail> msisdnorkitdetails { get; set; }
        DbSet<newtestsimrequisitionheader> newtestsimrequisitionheaders { get; set; }
        DbSet<newtestsimrequisitionline> newtestsimrequisitionlines { get; set; }
        DbSet<msisdnorkitdetailshistory> msisdnorkitdetailshistories { get; set; }
        DbSet<usagecategoryhistory> usagecategoryhistories { get; set; }
        DbSet<TermAndConditions> termsandconditionss { get; set; }
        IDbSet<EmailOutBox> EmailOutBox { get; set; }

        DbSet<Sim> Sim { get; set; }
        DbSet<ActivationRequest> ActivationRequest { get; set; }
        DbSet<ActivationRequestSim> ActivationRequestSim { get; set; }


        /*log*/
        DbSet<SimLog> SimLog { get; set; }
        DbSet<ActivationRequestLog> ActivationRequestLog { get; set; }
        DbSet<ActivationRequestSimLog> ActivationRequestSimLog { get; set; }

        /*EF defaults*/
        //DatabaseFacade Database { get; }
        //ChangeTracker ChangeTracker { get; }
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}
