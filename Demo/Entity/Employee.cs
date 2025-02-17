using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    // EF ==> support 4 ways for mapping classes in data base [table - view - function]
    // 1. By Convention [ default behavior ]
    // 2. Data annotation [ set of attribute ]
    // 3. Fluent APIS
    // 4. Class Configuration
    // Entity
    // POCO class :: Plain OLD CLR Object
    //internal class Employee // table
    //{
    //    public int Id { get; set; } // Public Numeric property named [ Id | EmployeeId ] --> PK -- identity constraint
    //    public string Name { get; set; } // reference type -- required [ not allow null ] nvarchar(max)
    //    public int? Age { get; set; } // value type : int [age] - optional [allow null]
    //    public double Salary { get; set; } // value type : float[salary] - required
    //    public string? Email { get; set; } // reference type -- nvarchar(max) - optional 
    //    public DateTime dateTimeCreation { get; set; } // value type - datetime2 - required
    //}

    // 2. Data annotation
    //[Table("Hamada" , Schema = "dbo")]
    //public class Employee
    //{
    //[Key] // Pk has  identity constraint
    //[DatabaseGenerated(DatabaseGeneratedOption.None)] // Pk has  identity constraint
    //public int EmpId { get; set; }
    //[Required]
    //[Column ("EmpName" , TypeName = "varchar")]
    //[MaxLength (50)]
    //[StringLength (50 ,MinimumLength = 20)]
    //public string Name { get; set; }
    //[Range(20,60)]
    //public int? Age { get; set; }
    //[EmailAddress]
    //public string Email { get; set; }
    //[DataType (DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }
    //    [Column(TypeName = "money")]
    //    [DataType (DataType.Currency)]
    //    public double Salary { get; set; }
    //    [NotMapped]
    //    public int TotalSalary { get; set; }
    //}
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int? Age { get; set; } 
        public double Salary { get; set; } 
        public string Email { get; set; } 
        public DateTime dateTimeCreation { get; set; } 
    }
}
