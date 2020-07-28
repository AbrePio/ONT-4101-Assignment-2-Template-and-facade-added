using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Receiver
    {
        public double average;
        /*public double TM1, TM2, TM3, TM4;
        public double avg;
        public void Action(double tm1, double tm2, double tm3, double tm4)
        {
            TM1 = tm1 * 0.30;
            TM2 = tm2 * 0.30;
            TM3 = tm3 * 0.30;
            TM4 = tm4 * 0.10;
            avg = TM1 + TM2 + TM3 + TM4;
            Console.WriteLine("Hello " + avg);
        }

        *//*  public void Action1(double tm1)
          {
              TM1 = tm1 * 0.30;
              Console.WriteLine("Hi " + TM1);
          }
          public void Action2(double tm2)
          {
              TM2 = tm2 * 0.30;
              Console.WriteLine("Hi " + TM2);
          }
          public void Action3(double tm3)
          {
              TM3 = tm3 * 0.30;
              Console.WriteLine("Hi " + TM3);
          }
          public void Action4(double tm4)
          {
              TM4 = tm4 * 0.10;
              Console.WriteLine("Hi " + TM4);
          }*//*
        public void average(double tm1, double tm2, double tm3, double tm4)
        {
            for (int i = 0; i < 4; i++)
            {
                //avg = avg +
            }
            avg = avg + tm1;
            avg = avg + tm2;
            avg = avg + tm3;
            avg = avg + tm4;
            //avg = tm1 + tm2 + tm3 + tm4;
            Console.WriteLine("Average: " + avg);
        }


        //command pattern
        public void receiver()
        {
            avg = +avg;
            Console.WriteLine(avg);
        }
        //end command

        //command testing
        public List<TestMarks> currentItems { get; set; }
        public Receiver()
        {
            currentItems = new List<TestMarks>();
        }

        *//*public void ExecuteCommand(CommandBase command, TestMarks item)
        {
            command.Execute(this.currentItems, item);
        }*//*


        public void ShowCurrentItems()
        {
            double average = 0;
            foreach (var item in currentItems)
            {
                item.Display();
                average = average + item.test1;
                average = average + item.test2;
                average = average + item.test3;
                average = average + item.test4;
            }
            Console.WriteLine(average.ToString());
            Console.WriteLine("-----------------------");
        }
        //command testing end*/

                                //command testing from ASsignment 2 command testing app
        public List<TestMarks> currentMarks { get; set; }
        public Receiver()
        {
            currentMarks = new List<TestMarks>();
        }

        public void ExecuteCommand(CommandBase command, TestMarks mark)
        {
            command.Execute(this.currentMarks, mark);
        }

        public void ShowCurrentItems()
        {
            //double average = 0;
            foreach (var mark in currentMarks)
            {
                mark.Display();
                this.average = average + mark.test1;
                this.average = average + mark.test2;
                this.average = average + mark.test3;
                this.average = average + mark.test4;
            }
            Console.WriteLine("Final mark: " + average.ToString());
            Console.WriteLine("-----------------------");
                                


                                                                   // template testing start
            ConcreteClass concrete = new ConcreteClass();
            concrete.Proceed(average);
            average = average  + (concrete.tm5 * .10);
            Console.WriteLine("Final: " + average);
                                                                    // template testing end
                                                                    // facade testing start
            Facade facade = new Facade();
            facade.DisplayMarkResult(average);
            Pass pass = new Pass();
            PassWithDistinction passWithDistinction = new PassWithDistinction();
            Fail fail = new Fail();

            
                                                                    // facade end
        }
    }        //end testing

}

