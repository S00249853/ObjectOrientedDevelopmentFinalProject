using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public List<List<Game>> lists { get; set; }
        List<Review> postedReviews { get; set; }

        public User(string name, string pass)
        {
            userName = name;
            password = pass;
        }
    }
}
