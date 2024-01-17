using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public string? EmployeeId { get; set; }

        public string? FileNumber { get; set; }

        public string? EmployeeName { get; set; }

        public string? EmployeeAddress { get; set; }

        public string? EmployeePhone { get; set; }

        public string? EmployeeEmail { get; set; }

        public string? EmployeePhoto { get; set;}

        public string? Other { get; set;}

        // Relationship : Many to One
        public GeneralDepartment? GeneralDepartment { get; set; }

        public int GeneralDepartmentId { get; set; }

        public Department? Department { get; set; }

        public int DepartmentId { get; set; }

        public Branch? Branch { get; set; }

        public int BranchId { get; set; }

        public Town? Town { get; set; }

        public int TownId { get; set;}
    }
}
