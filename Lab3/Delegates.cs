using System;
namespace delexmaple
{
    public delegate void StudentDelegate(String msg);
    class main
    {
        public static void Main(string[] args)
        {
            StudentDelegate sd = new StudentDelegate(display);
            sd("Hi I am form the delegates how are you");
        }
        public static void display(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
