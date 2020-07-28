using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class TestMarks
    {
        public double test1 { get; set; }
        public double test2 { get; set; }
        public double test3 { get; set; }
        public double test4 { get; set; }
        public TestMarks(double test1, double test2, double test3, double test4)
        {
            this.test1 = test1;
            this.test2 = test2;
            this.test3 = test3;
            this.test4 = test4;
        }

        public void Display()
        {
            /*//Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + test1.ToString());
            Console.WriteLine("Amount: " + test2.ToString());
            Console.WriteLine("Amount: " + test3.ToString());
            Console.WriteLine("Amount: " + test4.ToString());

            // Console.WriteLine("Price: $" + Price.ToString());*/
            Console.WriteLine("Tests mark percentages for final mark: " + test1 + ", " + test2 + ", " + test3 + ", " + test4);
        }
    }
}
