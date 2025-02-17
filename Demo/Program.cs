using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region What Is EF Core ?
            // Entity Framework Core ==> ORM tool into dotnet 
            // ORM ==> object relation mapper ==> interact between application & database
            // Mapping [Code First : generate table per each class - DB First : generate class per each table]
            // support : L2E [Linq to Entity] : CRUD
            #endregion
            #region 02 Ways Of Generation (TPC, TPH, TPCC)
            // TPC  ==> table per class
            // TPH  ==> table per hierachy
            // TPCC ==> table per concert class
            #endregion
            #region 03 EF Core Vs Dapper Vs ADO.NET
            // EF Core Vs Dapper Vs ADO.NET
            #endregion
            #region 04 Ways Of Mapping (By Convension)
            // EF ==> support 4 ways for mapping classes in data base [table - view - function]
            // 1. By Convention [ default behavior ]
            // Entity
            // POCO class :: Plain OLD CLR Object
            //internal class Employee // table
            //    {
            //        public int Id { get; set; } // Public Numeric property named [ Id | EmployeeId ] --> PK -- identity constraint
            //        public string Name { get; set; } // reference type -- required [ not allow null ] nvarchar(max)
            //        public int? Age { get; set; } // value type : int [age] - optional [allow null]
            //        public double Salary { get; set; } // value type : float[salary] - required
            //        public string? Email { get; set; } // reference type -- nvarchar(max) - optional 
            //        public DateTime dateTimeCreation { get; set; } // value type - datetime2 - required
            //    }
            #endregion
            #region 05 Ways Of Mapping (By Data Annotation)
            // 2. Data annotation
            //[Table("Hamada", Schema = "dbo")]
            //public class Employee
            //{
            //    [Key] // Pk has  identity constraint
            //    [DatabaseGenerated(DatabaseGeneratedOption.None)] // Pk has  identity constraint
            //    public int EmpId { get; set; }
            //    [Required]
            //    [Column("EmpName", TypeName = "varchar")]
            //    [MaxLength(50)]
            //    [StringLength(50, MinimumLength = 20)]
            //    public string Name { get; set; }
            //    [Range(20, 60)]
            //    public int? Age { get; set; }
            //    [EmailAddress]
            //    public string Email { get; set; }
            //    [DataType(DataType.PhoneNumber)]
            //    public string PhoneNumber { get; set; }
            //    [Column(TypeName = "money")]
            //    [DataType(DataType.Currency)]
            //    public double Salary { get; set; }
            //    [NotMapped]
            //    public int TotalSalary { get; set; }
            //}
            #endregion
            #region 06 DbContext & Installing Required Packages
            //AppDbContext appDb = new AppDbContext();
            #endregion
            #region 07 Our First Migration & Installing Required Packages
            //AppDbContext appDb = new AppDbContext();
            //appDb.Database.Migrate();
            #endregion
        }
    }
}
  