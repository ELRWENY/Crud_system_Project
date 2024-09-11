
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class operations
    {
        Dictionary<double, Employee> EmployeeList = new Dictionary<double, Employee>();
        public void Add_User()
        {
            Employee employee = new Employee();


            Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();
            employee.setName(name);

            Console.WriteLine("Enter Employee Number : ");
            double num = double.Parse(Console.ReadLine());
            employee.setNumber(num);

            Console.WriteLine("Enter Employee Age: ");
            int age = int.Parse(Console.ReadLine());
            employee.setAge(age);

            Console.WriteLine("Enter Employee profession : ");
            string prof = Console.ReadLine();
            employee.setProfession(prof);

            Console.WriteLine("Enter Employee Salary : ");
            decimal s_salary = decimal.Parse(Console.ReadLine());
            employee.set_starting_salary(s_salary);

            Console.WriteLine('\n');


            Console.WriteLine(@$"
/////////////////Employee details is :\\\\\\\\\\\\\\\\ 

employee Name is : {employee.Name}
employee Number is : {employee.number}
employee Age is : {employee.Age}
employee Profession is : {employee.profession}
employee Salary is : {employee.start_Salary}

1->> Confirm Data
2->> Cancel
");
            int confirm = int.Parse(Console.ReadLine());
            while (confirm > 2 || confirm < 1)
            {
                Console.WriteLine("Enter valid value : ");
                confirm = int.Parse(Console.ReadLine());
            }
            if (confirm == 2)
            {
                Console.WriteLine("Data Removed !");
            }
            else
            {
                Console.WriteLine("Data Confirmed :)");
                EmployeeList.Add(employee.number, employee);
                Console.WriteLine("User Added");
            }
        }

        public void Update_User()
        {
            Console.Write("Enter The Number Of User : ");
            int num_of_user = int.Parse(Console.ReadLine());
            Console.WriteLine('\n');

            Console.WriteLine("Information Of User Is : ");
            Employee employee = EmployeeList[num_of_user];
            Display_User_Data(employee);


            make_operations();

            void make_operations()
            {


                Console.Write("which Information You Want To Update ?\n1-->Name\n2-->Age\n3-->Profession\n4-->Salary\n");
                int update = int.Parse(Console.ReadLine());
                Console.WriteLine('\n');

                while (update > 4 || update < 1)
                {
                    Console.Write("Invalid Input , Enter Number Between 1 and 5 : ");
                    update = int.Parse(Console.ReadLine());
                    Console.WriteLine('\n');
                }
                if (update == 1)
                {
                    Console.Write("Enter New User Name : ");
                    string newName = Console.ReadLine();
                    Console.WriteLine('\n');
                    employee.setName(newName);
                    Console.WriteLine("Name Has Changed successfully\nNew User Data is : ");
                    Display_User_Data(employee);

                }

                else if (update == 2)
                {
                    Console.Write("Enter New User Age : ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.WriteLine('\n');
                    employee.setAge(newAge);
                    Console.WriteLine("Age Has Changed successfully\nNew User Data is : ");
                    Display_User_Data(employee);

                }
                else if (update == 3)
                {
                    Console.Write("Enter New User Profession : ");
                    string newProfession = Console.ReadLine();
                    Console.WriteLine('\n');
                    employee.setProfession(newProfession);
                    Console.WriteLine("Profession Has Changed successfully\nNew User Data is : ");
                    Display_User_Data(employee);

                }
                else
                {
                    Console.Write("Enter New User Starting Salary : ");
                    decimal new_start_salary = decimal.Parse(Console.ReadLine());
                    Console.WriteLine('\n');
                    employee.set_starting_salary(new_start_salary);
                    Console.WriteLine("Salary Has Changed successfully\nNew User Data is : ");
                    Display_User_Data(employee);

                }
            }
        }

        public void Print_all_Users()
        {
            int i = 1;
            foreach (var emp in EmployeeList)
            {
                Console.WriteLine($"\n-----------> User \" {i} \" :<----------- \n");

                Console.WriteLine($"User Number is: {emp.Key}\nUser Name is: {emp.Value.Name}\nUser Age is: {emp.Value.Age}\nUser Profession is : {emp.Value.profession}\nUser Salary is : {emp.Value.start_Salary}");
                i++;
            }
        }

        public void Remove_User() 
        {
            Console.Write("Enter The Number Of User To Be Removed : ");
            int remove=int.Parse(Console.ReadLine());
            Console.WriteLine('\n');
            if (EmployeeList.ContainsKey(remove) == true)
            {
                EmployeeList.Remove(remove);
                Console.WriteLine("User Removed Successfully\n");
            }
            else
            {
                Console.WriteLine("User Not Found ");
            }
        }

        void Display_User_Data(Employee employee)
        {
            Console.WriteLine(@$"
/////////////////Employee details is :\\\\\\\\\\\\\\\\ 

employee Name is : {employee.Name}
employee Number is : {employee.number}
employee Age is : {employee.Age}
employee Profession is : {employee.profession}
employee Salary is : {employee.start_Salary}


");

        }


    }
}

