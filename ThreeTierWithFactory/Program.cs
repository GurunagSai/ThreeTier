using System;

namespace ThreeTierWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePortal employeePortal = new EmployeePortal();
            employeePortal.UserControl();
            Console.ReadLine();
        }
    }
}
