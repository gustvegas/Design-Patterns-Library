using System;

namespace AdapteePattern
{
    public class Employees
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "11", "juan", "teamLeader" };
            employees[1] = new string[] { "22", "juan", "teamLeader" };
            employees[2] = new string[] { "33", "juan", "teamLeader" };
            employees[3] = new string[] { "44", "juan", "teamLeader" };

            return employees;
        }
    }
}