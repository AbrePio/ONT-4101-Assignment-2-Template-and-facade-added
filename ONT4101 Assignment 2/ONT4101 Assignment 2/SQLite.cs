using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class SQLite
    {
        public double tm2;
        public void enterTM2()
        {
            Console.Write("Please enter TM2 mark: ");
            
            
            tm2 = double.Parse(Console.ReadLine());
        }
       /* public void RunCommand()
        {

            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.param2 = tm2;
            invoker.command = command;
            invoker.ExecuteCommand();
            //invoker.ExecuteCommand1();
            //invoker.ExecuteCommand2();
            //invoker.ExecuteCommand3();
            //invoker.ExecuteCommand4();
        }*/
    }
}
