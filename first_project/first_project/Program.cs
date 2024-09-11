global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace first_project
{
    class Programe
    {
        static void startword()
        {
            string asciiArt = @"
 __ .__ .  ..__    __..   ,__..___..___.  .
/  `[__)|  ||  \  (__  \./(__   |  [__ |\/|
\__.|  \|__||__/  .__)  | .__)  |  [___|  |                    
 ";
            Console.WriteLine(asciiArt);
            Console.WriteLine("Date Of Openning Is : " + DateTime.Now.ToShortTimeString() + '\n');
            Console.WriteLine(@"Choose Operation To Be Done :
1--> Add User
2--> Update User Data
3--> Delete User
4--> Print All Users Data
 ");
        }
        static void end()
        {
            Console.WriteLine(@"
 , .       ._                        , .                 ,         
-+-|_ \./  |, _ ._.  . . __*._  _   -+-|_  _    __  . __-+- _ ._ _ 
 | [ )/'\  | (_)[    (_|_) |[ )(_]   | [ )(/,  _) \_|_)  | (/,[ | )
                               ._|                ._|              
");
        }
        static void Main(string[] args)
        {
            operations operations = new operations();
            bool while_var = true;
            while (while_var)
            {
                startword();

                int choose = int.Parse(Console.ReadLine());
                while (choose > 4 || choose < 1)
                {
                    Console.WriteLine("Invslid Inpot , Inter value from \"1\" to \"4\" ");
                    choose = int.Parse(Console.ReadLine());
                }
                if (choose == 1)
                {
                    operations.Add_User();
                }
                else if (choose == 2)
                {
                    operations.Update_User();
                }
                else if (choose == 3)
                {
                    operations.Remove_User();
                }
                else
                {
                    operations.Print_all_Users();
                }

                Console.WriteLine("Do you Want To Make Another Operations ? ::(y->YES and n-> NO):: \n");
                string yn = Console.ReadLine();
                if ((yn == "y" || yn == "Y"))
                {
                    while_var = true;
                }
                else if (yn == "n" || yn == "N")
                {
                    Console.WriteLine("Thank You :)");
                    while_var = false;
                    end();
                    break;
                }
                else
                {
                    while (while_var)
                        Console.WriteLine("Enter valid inpot ::(y->YES and n-> NO)::\n");
                    yn = Console.ReadLine();
                    while_var = false;
                }
                Console.Clear();
            }
        }
    }
}



