using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LTTTask
{



   class Student
    {
        public string name;
        public int age;
        public string firstName;
        public string lastName;
        public string contact;
        public string dob;
        public string course;
        public int admissionfee;
        public Student(string firstName, string lastName, string contact, string course, string dob, int admissionfee) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contact = contact;
            this.dob = dob;
            this.course = course;
            this.admissionfee = admissionfee;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "0";
            Console.WriteLine("...........Welcome To College Admission App..............");


            do
            {
                Console.WriteLine("Enter Student's Id to register");
                string id = Console.ReadLine();
                int idnum;
                if (int.TryParse(id, out idnum))
                {
                    Console.
                        WriteLine("Enter Student's First Name");
                    string firstName = Console.ReadLine();
                    Console.
                        WriteLine("Enter Student's Second Name");
                    string secondName = Console.ReadLine();
                    Console.WriteLine("Enter Student's  DOB in DD-MM-YYYY format");
                    string dob = Console.ReadLine();
                    Console.WriteLine("Enter Student's  contact number");
                    string contactNo = Console.ReadLine();
                    Dictionary<int, object> My_dict = new Dictionary<int, object>();
                    Console.WriteLine("Enter Any number According to Option: 1:B.Tech \n 2:MBBS \n 3:Bsc");
                    string option = Console.ReadLine();
                    int option = Int32.Parse(option);
                    {
                        if (option == 1)
                        {
                            Console.WriteLine("You Have Selected B.Tech");
                            Console.WriteLine("The amount need to be paid :50000");
                            Console.WriteLine("Enter 1 to add new user else press any other key");
                            str = Console.ReadLine();

                            Student admidssion = new Student(firstName, secondName, contactNo, dob, "B.Tech", 5000);
                            My_dict.Add(123, admidssion);


                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("You Have Selected MBBS");
                            Console.WriteLine("The amount need to be paid :100000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");
                            str = Console.ReadLine();

                            Student admidssion = new Student(firstName, secondName, contactNo, dob, "MBBS", 50000);

                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("You Have Selected Bsc");
                            Console.WriteLine("The amount need to be paid :40000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");

                            str = Console.ReadLine();

                            Student admidssion = new Student(firstName, secondName, contactNo, dob, "Bsc", 20000);

                        }
                        else
                        {
                            Console.WriteLine("....Invalid Entry.....");
                        }
                    }

                }
                else
                {
                    Console.WriteLine(".....You Should enter a number.....");
                }
            }
            while (str == "1");
            Console.WriteLine("To print details press 1\n");
            string print = Console.ReadLine();
            int val;
            if (int.TryParse(print, out val))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(".............You Have Entered Invalid Number..............");
            }
        }

    }
    
}
