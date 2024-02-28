using System;
namespace hello
{
class one
    {
        public static void Main(string[] args)
        {
            /** Console.WriteLine("Enter the value for A ");
             int  a =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a);
             Console.WriteLine("Enter a String ");
             string s = Console.ReadLine();
             Console.WriteLine(s);
             person p1 =new person();
             Console.WriteLine(p1.a);
             p1.display();
            college c1 = new college(1234,"Presidency University");
            college c2 = new college();
            Console.WriteLine(c1.cid);
            Console.WriteLine(c2.name);**/
            Console.WriteLine(bank.ifsc_code);
            Console.WriteLine(bank.branch_name);
            bank.timings();

        }
    }
    /**class person
    {
        public int a = 10;
        public void display()
        {
            Console.WriteLine("I am the display Function");
        }
    }**/
    /**class college
    {
        public int cid;//Global Variable
        public string name;

        public college()//For default Constructor 
        {
            Console.WriteLine("I am in the Default Constructor");
        }

        public college(int cid1, string name1)//Local Variable
        {
            this.cid = cid1;//mapping of LV to GV
            this.name = name1;
        }
    }**/
    class bank
    {
        static public int ifsc_code = 12345678;
        static public string branch_name = "pune";
        static public void timings()
        {
            Console.WriteLine("The Banking timing is 10:30 to 3:30");
        }
    }
}
