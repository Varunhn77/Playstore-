using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class User:IUser
    {
        //Properties
        public int a; //variable
        public int Id { get; set; }
        public string Name { get; set; } = "Varun";
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }

        private int UserKey { get; set; } = 123;

        public void AddUser()
        {
            
        }

        //Functions
        //Syntax: public return/no-return-type Methodname(){}

        public void CreateUser()
        {
            Console.WriteLine("User Key:" + UserKey);
            Console.WriteLine("User Registration");
            //How to read  input from keyboard
            Console.Write("Enter name: ");
            Name = Console.ReadLine(); //read input
            Console.Write("Enter mobile: ");
            Mobile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome, " + Name);
        }

        public void DeleteUser()
        {
            
        }

        public void GetUser()
        {
            
        }

        public void UpdateUser()
        {
            
        }
    }
}
