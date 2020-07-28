using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Adapter:ITarget
    {
        MySQL mysql;
        SQLite sqlite;
        Firebase firebase;
        MSSQL mssql;
        public Adapter(MySQL target1, SQLite target2, Firebase target3, MSSQL target4)
        {
            this.mysql = target1;
            this.sqlite = target2;
            this.firebase = target3;
            this.mssql = target4;
        }

        public void TM1()
        {
            mysql.enterTM1();
            //mysql.RunCommand();
        }
        public void TM2()
        {
            sqlite.enterTM2();
            //sqlite.RunCommand();
        }
        public void TM3()
        {
            firebase.enterTM3();
            //firebase.RunCommand();
        }
        public void TM4()
        {
            mssql.enterTM4();
            //mssql.RunCommand();
        }
    }
}
