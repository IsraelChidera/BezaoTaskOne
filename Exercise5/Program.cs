using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    //Implement a basic authentication system scope: User should be able to register
    //and login
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Input username and password");
            List<string> User = new List<string>();
                        
            string registeredUsername = Console.ReadLine();
            string registeredPassword = Console.ReadLine();
            
            User.Add(registeredUsername);
            User.Add(registeredPassword);

            Console.WriteLine("Congrats, registration is done!");

            Console.WriteLine(" ");
            Console.WriteLine("Login : ");
            string username = Console.ReadLine();
            Console.WriteLine("Input password : ");
            string password = Console.ReadLine();
            
            //Console.WriteLine("username:" + User[0]);
            //Console.WriteLine("username:" + User[1]);

            if(username != registeredUsername && password != registeredPassword)
            {
                Console.WriteLine("Invalid credentials, Login again");
            }
            else if(username == registeredUsername && password == registeredPassword)
            {
                Console.WriteLine("Congrats, Login is successful");
            }            

        }
    }
}
