using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public interface CommandBase
    {
        //void ExecuteCalculation();
        /*void ExecuteCalc1();
        void ExecuteCalc2();
        void ExecuteCalc3();
        void ExecuteCalc4();*/
        //void AVG();

        //commmand testing
        //void Execute(List<TestMarks> order, TestMarks newTest);


        // command testing end
                                 //command testing from ASsignment 2 command testing app
        void Execute(List<TestMarks> testMarks, TestMarks newTest);
                                 //testing end
    }

}
