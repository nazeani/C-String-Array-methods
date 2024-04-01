using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cm
{
    internal class Student
    {
        public string Fullname;
        private string _groupNo;
        public int AvgPoint;
        public string GroupNo 
        {
            get { 
                return _groupNo; 
            }
            set {
                
                string first=value.Substring(0,2);
                string secondstr=value.Substring(2);
                int second;
                if (value.Length == 5)
                {
                    if (!int.TryParse(secondstr, out second))
                    {
                    Console.WriteLine( "reqem deyl");
                    }
                    
                    if (first.ToUpper() == first && second >= 0 && second < 1000)
                    {
                      _groupNo = value;
                    }
                    else
                    {
                      Console.WriteLine("falsee");
                    }
                }
                else
                {
                        Console.WriteLine("value.Length == 5");
                }
                
            }
        }
        public Student()
        {
            
        }
        public Student(string fullname)
        {
            Fullname = fullname;
        }
        public Student(string fullname,string groupNo):this(fullname)
        {
            GroupNo = groupNo;
        }
        public Student(string fullname, string groupNo, int avgPoint) : this(fullname,groupNo)
        {
            AvgPoint = avgPoint;
        }

    }
}
