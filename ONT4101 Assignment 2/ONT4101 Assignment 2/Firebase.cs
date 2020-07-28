using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Firebase
    {
        public double tm3;
        public void enterTM3()
        {
            Console.Write("Please enter TM3 mark: ");
            tm3 = double.Parse(Console.ReadLine());
        }

        /*public void RunCommand()
        {

            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.param3 = tm3;
            invoker.command = command;
            invoker.ExecuteCommand();
            //invoker.ExecuteCommand1();
            //invoker.ExecuteCommand2();
            //invoker.ExecuteCommand3();
            //invoker.ExecuteCommand4();
        }*/
    }
}
