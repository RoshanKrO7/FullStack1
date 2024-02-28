using System;
namespace smaple
{
    partial class project
    {
        public void login() 
        {
            Console.WriteLine("I am in the LogIn Page");
        }
    }
    partial class project
    {
        public void home()
        { 
            Console.WriteLine("I am in the Home page");
        }
    }
    partial class project
    {
        public void logout() 
        {
            Console.WriteLine("I am in the Logout page");
        }

    }
    class main
    {
        public static void Main(string[] args)
        {
            project p1= new project();
            p1.login();
            p1.home();
            p1.logout();

        }
    }
}
