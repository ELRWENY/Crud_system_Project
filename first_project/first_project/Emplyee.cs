using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Employee
    {
        public double number {  get; set; }
        public string profession { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal start_Salary { get; set; }

        public  void setProfession(string prof)
            { this.profession =prof; }

        public void setName(string name)
            { this.Name = name; }

        public void setAge(int age)
            { this.Age = age; }
        public void setNumber(double num)
            { this.number = num; }

        public void set_starting_salary(decimal s_salary)
            { this.start_Salary = s_salary; }



    }
}
