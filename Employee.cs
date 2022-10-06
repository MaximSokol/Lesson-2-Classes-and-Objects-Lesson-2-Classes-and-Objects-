using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___2___Classes_and_Objects_
{
    class Employee
    {
        readonly List<double> experience;
        readonly List<string> position; 

        string fname;
        string sname;
        double taxCollection;
        //-------------------------------------------------------------------------------

        public Employee(string fname, string sname)
        {
            this.fname = fname;
            this.sname = sname;

            experience = new List<double>()
            {
                2.5,
                4.4,
                5.7,
                7.4,
                10.6
            };

            position = new List<string>()
            {
                "Manager",
                "FBoss",
                "SBoss",
                "Director",
                "Regional Director"
            };
        }
        //-------------------------------------------------------------------------------

        public double CountPosition()
        {
            double salarykoef = 0.0;

            for (int i = 0; i < position.Count; i++)
            {
                switch (position[i].ToLower())
                {
                    case "manager":
                        salarykoef = 200;
                        break;
                    case "developer":
                        salarykoef = 150;
                        break;
                    case "secretary":
                        salarykoef = 80;
                        break;
                    case "cleaner":
                        salarykoef = 65;
                        break;
                    default:
                        salarykoef = 100;
                        break;
                }

                switch (experience[i])
                {
                    case 0:
                        salarykoef *= 1.5;
                        break;
                    case 1:
                        salarykoef *= 2;
                        break;
                    case 2:
                        salarykoef *= 2.5;
                        break;
                    default:
                        salarykoef *= 5;
                        break;
                }
            }
            return salarykoef;
        }
        //-------------------------------------------------------------------------------

        public void ShowSalary()
        {
            Console.WriteLine("Зарплата {0}, подоходный налог {1}", CountPosition(), CountPosition() * 0.13);
        }
        //-------------------------------------------------------------------------------
    }
}
