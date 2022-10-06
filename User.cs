using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___2___Classes_and_Objects_
{
   public class User
    {
        string login;
        string fname;
        string sname;
        int age;
        readonly DateTime birtday;
        //-------------------------------------------------

        public User() { }

        public User(string login, string fname, 
            string sname, int age)
        {
            this.login = login;
            this.fname = fname;
            this.sname = sname;
            this.age = age;
            this.birtday = new DateTime(2001, 11, 17);
        }
        //-------------------------------------------------

        public void ShowUserDate()
        {
            Console.WriteLine("Date of a user:\n");
            Console.WriteLine($"Login:\t{login}");
            Console.WriteLine($"First Name:\t{fname}");
            Console.WriteLine($"Second Name:\t{sname}");
            Console.WriteLine($"Age:\t{age}");
            Console.WriteLine($"Birthday:\t{birtday.ToShortDateString()}");
        }
        //-------------------------------------------------
    }
}
