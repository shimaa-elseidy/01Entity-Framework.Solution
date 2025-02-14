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
    }
    }
}
  