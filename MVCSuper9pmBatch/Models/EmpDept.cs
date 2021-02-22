using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSuper9pmBatch.Models
{
    public class EmpDept
    {
        public Employee emp { get; set; }
        public DepartmentModel dept { get; set; }
    }
}