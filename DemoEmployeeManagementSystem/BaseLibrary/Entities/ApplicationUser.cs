using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }
        public DateTime? TokenExpireTime { get; set; }
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }
        public int? GeneralDepartmentId { get; set; }
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int? RelatioshipId { get; set; }
        public Relatioship? Relatioship { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
