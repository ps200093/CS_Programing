using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_11월_05일_실습
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] th = new Thread[3]; // 스레드 객체 참조 배열 생성
            Account obj = new Account(10000); // 계좌 잔액을 만원으로 초기화
            for (int i = 0; i < 3; i++)
            { // 3개의 Trans 스레드 생성
                th[i] = new Thread(new ThreadStart(obj.Trans));
                th[i].Name = "고객[" + i + "]"; // 스레드 Name 설정
            }
            for (int i = 0; i < 3; i++)
            {
                // 3개의 Trans 스레드 실행
                th[i].Start();
            }
        }
    }
}
