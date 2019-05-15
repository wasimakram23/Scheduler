using System;
using System.Collections.Generic;

namespace Db.Isms.Table.Old
{
    
    
    public  class employee
    {
        public employee()
        {
            //this.msisdnorkitdetails = new HashSet<msisdnorkitdetail>();
            //this.msisdnorkitdetailshistories = new HashSet<msisdnorkitdetailshistory>();
            //this.msisdnorkitdetails1 = new HashSet<msisdnorkitdetail>();
            //this.employeevsgroups = new HashSet<employeevsgroup>();
        }
    
        public int EmployeeID { get; set; }             /*id*/
        public string Name { get; set; }
        public string EmpCode { get; set; }
        public string DomainID { get; set; }            /*DbChange: need to make it unique*/
        public int DepartmentID { get; set; }
        public int DivisionID { get; set; }
        public string Mobile { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public Nullable<int> OrganizationID { get; set; }
        public int DepartmentHODID { get; set; }
        public int UserGroupID { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        //public virtual department department1 { get; set; }
        //public virtual department division1 { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<msisdnorkitdetail> msisdnorkitdetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<msisdnorkitdetailshistory> msisdnorkitdetailshistories { get; set; }
        //public virtual usergroup usergroup { get; set; }
        //public virtual organization organization { get; set; }
        //public virtual organization organization1 { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<msisdnorkitdetail> msisdnorkitdetails1 { get; set; }
        public virtual ICollection<employeevsgroup> employeevsgroups { get; set; }
    }
}
