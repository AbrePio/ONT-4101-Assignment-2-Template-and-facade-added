using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class ConcreteCommand : CommandBase
    {
        /*public double param1 { get; set; }
        public double param2 { get; set; }
        public double param3 { get; set; }
        public double param4 { get; set; }
        protected Receiver _receiver;
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void ExecuteCalculation()
        {
            _receiver.Action(param1, param2, param3, param4);
        }

        *//*public void ExecuteCalc1()
        {
            _receiver.Action1(param1);
        }
        public void ExecuteCalc2()
        {
            _receiver.Action2(param2);
        }
        public void ExecuteCalc3()
        {
            _receiver.Action3(param3);
        }
        public void ExecuteCalc4()
        {
            _receiver.Action4(param4);
        }*//*
        public void AVG()
        {
            _receiver.average(param1, param2, param3, param4);
        }
       

        // command testing
        public void ExecuteCommand(List<TestMarks> currentItems, TestMarks newTest)
        {
            currentItems.Add(newTest);
        }
        public class CommandFactory
        {
            public CommandBase GetCommand(int commandOption, Receiver receiver)
            {
                switch (commandOption)
                {
                    case 1:
                        return new ConcreteCommand(receiver);
                    *//*case 2:
                        return new ModifyCommand();
                    case 3:
                        return new RemoveCommand();*//*
                    default:
                        return new ConcreteCommand(receiver);
                }
            }
        }

    }
    
    // command testing end*/
        //command testing from ASsignment 2 command testing app
        public void Execute(List<TestMarks> testMarks, TestMarks newtests)
        {
            testMarks.Add(newtests);
        }
        //testing end
    }
}



