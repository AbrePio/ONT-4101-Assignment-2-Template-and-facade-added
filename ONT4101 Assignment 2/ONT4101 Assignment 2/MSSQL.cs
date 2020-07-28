using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class MSSQL
    {
        public double tm4;
        public void enterTM4()
        {
            Console.Write("Please enter TM4 mark: ");
            tm4 = double.Parse(Console.ReadLine());
        }

        /*public void RunCommand()
        {

            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.param4 = tm4;
            invoker.command = command;
            invoker.ExecuteCommand();
            //invoker.ExecuteCommand1();
            //invoker.ExecuteCommand2();
            //invoker.ExecuteCommand3();
            //invoker.ExecuteCommand4();
            invoker.Average();
            //Console.WriteLine(receiver.TM1 + receiver.TM2 + receiver.TM3 + receiver.TM4);
        }*/

        //command testing
        
        //command testing end
    }
}
