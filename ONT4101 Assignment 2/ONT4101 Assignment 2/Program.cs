using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter student number: ");
            string studentNo = Console.ReadLine();
            Console.Write("Please enter name: ");
            string studentName = Console.ReadLine();
            Console.Write("Please enter surname: ");
            string studentSurname = Console.ReadLine();
            Student student = new Student(studentNo, studentName, studentSurname);
            
            // Adapter 
            MySQL adaptee1 = new MySQL();
            SQLite adaptee2 = new SQLite();
            Firebase adaptee3 = new Firebase();
            MSSQL adaptee4 = new MSSQL();
            Adapter adapter = new Adapter(adaptee1, adaptee2, adaptee3, adaptee4);

            adapter.TM1();
            adapter.TM2();
            adapter.TM3();
            adapter.TM4();
            // End Adapter

            Console.WriteLine("just testing... tm2: " + adaptee2.tm2);

            //command testing from ASsignment 2 command testing app
            Invoker invoker = new Invoker();
            invoker.SetCommand(1);
            invoker.SetTestMark(new TestMarks(adaptee1.tm1 * .30, adaptee2.tm2 * .30, adaptee3.tm3 * .30, adaptee4.tm4 * .10));
            invoker.ExecuteCommand();
            invoker.ShowCurrentOrder();
            //testing end

            Console.ReadLine();
        }
    }
}
