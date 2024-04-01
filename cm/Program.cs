using System.Threading.Channels;

namespace cm
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student student1 = new Student();
            student1.Fullname = "Leyla";
            student1.GroupNo = "AB274";
            student1.AvgPoint = 89;
            Student student2 = new Student();
            student2.Fullname = "Nermin";
            student2.GroupNo = "AB203";
            student2.AvgPoint = 76;
            Student student3 = new Student();
            student3.Fullname = "Nazrin";
            student3.GroupNo = "AB202";
            student3.AvgPoint = 80;

          Group group = new Group();

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            //Console.WriteLine($"Enter No:");
            //student1.GroupNo = Console.ReadLine();
            string answer;
            do
            {
                Console.WriteLine("Choose:1/2/3/0");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("Enter the students's Fullname:");
                    string FullName = Console.ReadLine();
                    Console.WriteLine("Enter studenrs's GroupNo:");
                    string GroupNo;
                    string first;
                    string secondstr;
                    int second;
                    do
                    {
                        GroupNo = Console.ReadLine();
                        first = GroupNo.Substring(0, 2);
                        secondstr = GroupNo.Substring(2);
                        if (!(int.TryParse(secondstr, out second) && first.ToUpper() == first && second >= 0 && second < 1000))
                        {
                            Console.WriteLine("It must consist of 2 capital letters and 3 numbers!");
                        }
                    }

                    while (!(GroupNo.Length == 5 && int.TryParse(secondstr, out second) && first.ToUpper() == first && second >= 0 && second < 1000));

                    string AvgPointstr = "";
                    int AvgPoint;
                    do
                    {
                        Console.WriteLine("Enter the employee's age:");
                        AvgPointstr = Console.ReadLine();
                    }
                    while (!int.TryParse(AvgPointstr, out AvgPoint));
                    Student student = new Student(FullName, GroupNo, AvgPoint);
                    Group students = new Group();
                    group.AddStudent(student);
                }

                if (answer == "2")
                {
                    group.ShowStudentsInfo();
                }
                if (answer == "3")
                {
                    Console.WriteLine("Student Fullname:");
                    string s = Console.ReadLine();
                    if (s == student1.Fullname)
                    {
                        group.ShowStudentInfo(student1);

                    }

                    else if (s == student2.Fullname)
                    {
                        group.ShowStudentInfo(student2);

                    }
                    else if (s == student3.Fullname)
                    {
                        group.ShowStudentInfo(student3);

                    }
                    else
                    {
                        Console.WriteLine("This student is not in any group");
                    }

                }
                
            }
            while (answer != "0");
            
        }
    }
}

