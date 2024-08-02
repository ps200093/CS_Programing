namespace CS_TEST_맘껏_써도됌
{
    delegate void delegatetest1();
    delegate void delegatetest2(int i);

    delegate void multiDelegate(string str);
    class Class6
    {
        public void method()
        {
            System.Console.WriteLine("method");
        }
        internal void method2(int i)
        {
            System.Console.WriteLine("method2" + i);
        }
        public static void method3(string str)
        {
            System.Console.Write("정적\t");
            System.Console.WriteLine(str + "\r\n");
        }

        public void method4(string str)
        {
            System.Console.Write("일반\t");
            System.Console.WriteLine(str + "\r\n");
        }
    }
}
