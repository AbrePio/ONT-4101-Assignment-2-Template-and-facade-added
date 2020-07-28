using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ONT4101_Assignment_2.ConcreteCommand;

namespace ONT4101_Assignment_2
{
    public class Invoker
    {
        /*public CommandBase command { get; set; }
        public void ExecuteCommand()
        {
            command.ExecuteCalculation();
        }

        *//*public void ExecuteCommand1()
        {
            command.ExecuteCalc1();
        }
        public void ExecuteCommand2()
        {
            command.ExecuteCalc2();
        }
        public void ExecuteCommand3()
        {
            command.ExecuteCalc3();
        }
        public void ExecuteCommand4()
        {
            command.ExecuteCalc4();
        }*//*
        public void Average()
        {
            command.AVG();
        }

        // command testing
        private CommandBase commandBase;
        private TestMarks testMarks;
        private Receiver receiver;

        public Invoker()
        {
            receiver = new Receiver();
        }

        public void SetCommand(int commandOption)
        {
            commandBase = new CommandFactory().GetCommand(commandOption, receiver);
        }

        public void SetMenuItem(TestMarks marks)
        {
            testMarks = marks;
        }

        *//*public void ExecuteCommand()
        {
            receiver.ExecuteCommand(commandBase, testMarks);

        }*//*

        public void ShowCurrentOrder()
        {
            receiver.ShowCurrentItems();
        }
        //testing end*/
        //command testing from ASsignment 2 command testing app
        private CommandBase commandBase;
        private TestMarks testMark;
        private Receiver receiver;

        public Invoker()
        {
            receiver = new Receiver();
        }

        public void SetCommand(int commandOption)
        {
            commandBase = new CommandFactory().GetCommand(commandOption);
        }

        public void SetTestMark(TestMarks mark)
        {
            testMark = mark;
        }

        public void ExecuteCommand()
        {
            receiver.ExecuteCommand(commandBase, testMark);
        }

        public void ShowCurrentOrder()
        {
            receiver.ShowCurrentItems();
        }
        //testing end
    }
}
