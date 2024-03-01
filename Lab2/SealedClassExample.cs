using System;
namespace smaple
{
    sealed class project
    {
        public void login() 
        {
            Console.WriteLine("I am in the LogIn Page");
        }
    }
     class subproject:project  //We can not Inherit the Sealed Class 
    {
        public void home()
        { 
            Console.WriteLine("I am in the Home page");
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
