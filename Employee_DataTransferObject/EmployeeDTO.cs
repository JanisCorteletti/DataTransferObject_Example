using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_DataTransferObject
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
    }
}
