using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace CS_10_24_실습_콘솔
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(args[0], FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(file);
            FileInfo s_file = new FileInfo(args[0]);

            char c;
            int charcnt = 0, linecnt = 0;

            while (true)
            {
                if (r.Peek() > -1)
                {
                    c = (char)r.Read();
                    Write(c);
                    charcnt++;
                    if (c == '\r')
                        linecnt++;
                }
                else
                    break;
            }

       
            WriteLine($"폴더이름 : {s_file.DirectoryName}");
            WriteLine($"파일이름 : {s_file.Name}");
            WriteLine($"확장자 : {s_file.Extension.ToString()}");
            WriteLine($"생성일 : {s_file.CreationTime.ToString()}");
            WriteLine($"파일크기 : {s_file.Length.ToString()}");
            WriteLine($"파일속성 : {s_file.Attributes.ToString()}");
            WriteLine($"문자수 : {charcnt}");
            WriteLine($"라인수 : {linecnt}");

            file.Close();
            r.Close();
        }
    }
}
