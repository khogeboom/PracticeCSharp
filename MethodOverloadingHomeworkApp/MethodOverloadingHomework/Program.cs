using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new EmployeeModel("Tim", "Corey", "John Smith", "Part-Time");
            var employee2 = new EmployeeModel("Tim", "Corey");
            var employee3 = new EmployeeModel("Tim", "Corey", "John Smith")

            Console.ReadLine();
        }
    }

    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Manager { get; set; }
        public string JobType { get; set; }
        public EmployeeModel()
        {

        }
        public EmployeeModel(string firstName, string lastName, string manager, string type)
        {
            FirstName = firstName;
            LastName = lastName;
            Manager = manager;
            JobType = type;
        }
        public EmployeeModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public EmployeeModel(string firstName, string lastName, string manager)
        {
            FirstName = firstName;
            LastName = lastName;
            Manager = manager;
        }
    }
}
