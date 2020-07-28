using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class MySQL
    {
        public double tm1;
        public void enterTM1()
        {
            Console.Write("Please enter TM1 mark: ");
            tm1 = double.Parse(Console.ReadLine());
        }

        /*public void RunCommand()
        {

            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.param1 = tm1;
            invoker.command = command;
            invoker.ExecuteCommand();
            //invoker.ExecuteCommand1();
            //invoker.ExecuteCommand2();
            //invoker.ExecuteCommand3();
            //invoker.ExecuteCommand4();
        }*/
    }
}
