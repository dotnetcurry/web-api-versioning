using System.Collections.Generic;

namespace WebApi_Versioning_CustomHeaders.Models
{
        public class EmployeeInfo
        {
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
            public int Salary { get; set; }
            public string DeptName { get; set; }

        }

        //Default Database Version
        public class EmployeeInfoDatabase : List<EmployeeInfo>
        {
            public EmployeeInfoDatabase()
            {
                Add(new EmployeeInfo() { EmpNo = 1, EmpName = "SS", Salary = 19000, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 2, EmpName = "MP", Salary = 11100, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 3, EmpName = "SK", Salary = 12300, DeptName = "D3" });
                Add(new EmployeeInfo() { EmpNo = 4, EmpName = "MS", Salary = 13300, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 5, EmpName = "SP", Salary = 16400, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 6, EmpName = "MS", Salary = 17500, DeptName = "D3" });
            }
        }

        //Database Version 1
        public class EmployeeInfoDatabaseV1 : List<EmployeeInfo>
        {
            public EmployeeInfoDatabaseV1()
            {
                Add(new EmployeeInfo() { EmpNo = 1, EmpName = "TS", Salary = 12000, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 2, EmpName = "MS", Salary = 12100, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 3, EmpName = "LS", Salary = 12200, DeptName = "D3" });
                Add(new EmployeeInfo() { EmpNo = 4, EmpName = "VB", Salary = 12300, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 5, EmpName = "PB", Salary = 12400, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 6, EmpName = "AB", Salary = 12500, DeptName = "D3" });
            }
        }

        //Database Version 1
        public class EmployeeInfoDatabaseV2 : List<EmployeeInfo>
        {
            public EmployeeInfoDatabaseV2()
            {
                Add(new EmployeeInfo() { EmpNo = 1, EmpName = "Tejas", Salary = 13000, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 2, EmpName = "Mahesh", Salary = 13100, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 3, EmpName = "Leena", Salary = 13200, DeptName = "D3" });
                Add(new EmployeeInfo() { EmpNo = 4, EmpName = "Vandana", Salary = 1300, DeptName = "D1" });
                Add(new EmployeeInfo() { EmpNo = 5, EmpName = "Prashant", Salary = 13400, DeptName = "D2" });
                Add(new EmployeeInfo() { EmpNo = 6, EmpName = "Aditya", Salary = 13500, DeptName = "D3" });
            }
        }
     
}