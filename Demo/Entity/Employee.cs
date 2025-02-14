using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    // EF ==> support 4 ways for mapping classes in data base [table - view - function]
    // 1. By Convention [ default behavior ]
    // Entity
    // POCO class :: Plain OLD CLR Object
    internal class Employee // table
    {
        public int Id { get; set; } // Public Numeric property named [ Id | EmployeeId ] --> PK -- identity constraint
        public string Name { get; set; } // reference type -- required [ not allow null ] nvarchar(max)
        public int? Age { get; set; } // value type : int [age] - optional [allow null]
        public double Salary { get; set; } // value type : float[salary] - required
        public string? Email { get; set; } // reference type -- nvarchar(max) - optional 
        public DateTime dateTimeCreation { get; set; } // value type - datetime2 - required
    }
}
