﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class ConcreteClass:Template
    {
        public double tm5;
        public override void Proceed(double avg)
        {
            if (avg < 50 && avg >= 45)
            {
                // Sup test
                Console.WriteLine("Sup test");
                supTest();
            }
            else if (avg >= 50)
            {
                // pass
                Console.WriteLine("pass");
            }
            else
            {
                // fail
                Console.WriteLine("fail");
            }
        }
        public override void supTest()
        {
            //double tm5;
            Console.WriteLine("Enter test mark 5: ");

            tm5 = double.Parse(Console.ReadLine());

        }
    }
}
