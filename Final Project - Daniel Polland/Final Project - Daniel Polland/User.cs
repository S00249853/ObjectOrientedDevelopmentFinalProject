using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project___Daniel_Polland
{
    internal class User
    {
        string Name { get; set; }
        string Password { get; set; }
        List<List<Game>> Lists { get; set; }

        public User(string name, string password) 
        {
            Name = name;
            Password = password;
        }
    }
}
