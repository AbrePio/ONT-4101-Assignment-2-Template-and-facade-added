using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Facade
    {
        private Pass pass;
        private PassWithDistinction passWithDistinction;
        private Fail fail;
        //private   string studentNo, studentName, studentSurname;
        
        
        public Facade()
        {
            pass = new Pass();
            passWithDistinction = new PassWithDistinction();
            fail = new Fail();
        }      
        public void DisplayMarkResult(double average)
        {
            Receiver receiver = new Receiver();
            //Student student = new Student(studentNo, studentName, studentSurname);
            Console.WriteLine("=======================");
            Console.WriteLine("STDNum: \t\t xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" );
            Console.WriteLine("Name \t\t\t xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" );
            Console.WriteLine("Surname \t\t cxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("Final Mark \t\t " + average);
            if (average >= 75)
            {
                passWithDistinction.PassWithDistinctionMethod();
            }
            else if (average > 50 && average < 75)
            {
                pass.PassMethod();
            }
            else if (average < 50)
            {
                fail.FailMethod();
            }
        }
    }
    class Pass
    {
        public void PassMethod()
        {
            Console.WriteLine("Result: \t\t Pass");
        }
    }
    class PassWithDistinction
    {
        public void PassWithDistinctionMethod()
        {
            Console.WriteLine("Result: \t\t Pass with Distinction");
        }
    }
    class Fail
    {
        public void FailMethod()
        {
            Console.WriteLine("Result: \t\t Fail");
        }
    }
}
