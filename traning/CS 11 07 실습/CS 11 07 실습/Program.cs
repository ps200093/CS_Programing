using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data;
using System.Data.OleDb;


namespace CS_11_07_실습
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = @"provider=Microsoft.ACE.OLEDB.12.0;
            //                            data source = D:\저장 폴더\ADOTest.accdb";
            string connectionString = @"provider=Microsoft.ACE.OLEDB.12.0;"
+ "data source = " + System.Environment.CurrentDirectory + @"\ADOTest.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);
            string commandString = "select * from phone";
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            myConnection.Open(); // 연결을 오픈
                                 // DataReader 객체 생성
            OleDbDataReader myReader = myCommand.ExecuteReader();//ExecuteNonQuery( )
                                                                 // 한 레코드 읽기

            string ResultMessage;
            for (int i = 0; i < myReader.FieldCount; i++)
            {
                Write(myReader.GetName(i) + "\t");
            }

            WriteLine();

            while (myReader.Read())
            {
                ResultMessage = myReader.GetInt32(0) + " | " + myReader.GetString(1) + " | " + myReader.GetString(2) + " | " + myReader.GetString(3); //Id, Name, Phone
                WriteLine(ResultMessage);
            }
            //myReader.Read();
            //// 레코드의 필드 참조
            //myReader.GetInt32(0); // 첫 번째 필드, 필드이름: myReader.GetName(0)
            //myReader.GetString(1); // 두 번째 필드, 필드이름: myReader.GetName(1)
        }
    }
}
