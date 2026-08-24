using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); student.AcceptDetails(); student.CheckScholarship(); student.DisplayDetails();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    class Student
    {
        public int GRNO { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Sem { get; set; }
        private int Fees { get; set; }
        private double NetFees { get; set; }
        private bool IsScholarship { get; set; }
        private const double Scholarship = 0.10;

        public Student()
        { Console.WriteLine("=== Welcome to Student Portal ===\n"); }
        public void AcceptDetails()
        {
            Console.Write("Enter Grno: ");
            GRNO = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Department: ");
            Department = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Sem: ");
            Sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fees: ");
            Fees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student is Eligible for Scholarship (1 for Yes / 0 for No) ?: "); 
            IsScholarship = Convert.ToInt32(Console.ReadLine()) == 1;
        }
        public void CheckScholarship()
        {
            if (IsScholarship)
            {
                NetFees = Fees - (Scholarship * Fees);
            }
            else
            {
                NetFees = Fees;
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("   STUDENT DETAILS");
            Console.WriteLine("=======================");
            Console.WriteLine("GRNO: " + GRNO);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Semester: " + Sem);
            Console.WriteLine("Original Fees: " + Fees);
            Console.WriteLine("Scholarship Applied: " + (IsScholarship ? "Yes" :"No"));
            Console.WriteLine("Net Fees to Pay: " + NetFees);
            Console.WriteLine("=======================");
        }
    }
}
