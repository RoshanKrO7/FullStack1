using System;

namespace inheritance_basic
{
    class human
    {
        public void kannada()
        {
            string k = "Kannada";
            Console.WriteLine("Hi, I am in Karnataka and I speak " + k);
        }
        public void telugu()
        {
            string t = "Telugu";
            Console.WriteLine("Hi, I am in Andhra Pradesh and I speak " + t);
        }
        public void English()
        {
            string e = "English";
            Console.WriteLine("Hi, I am in India and I speak " + e);
        }
        public void Bhojpuri()
        {
            string b = "Bhojpuri";
            Console.WriteLine("Hi, I am in Bhojpur and I speak " + b);
        }
    }

    class alien : human // single inheritance
    {
        public void telepathy()
        {
            Console.WriteLine("Hi, I am an alien and I can use telepathy and i met some people in india here they are");
            telugu();
            English();
            kannada();
            Bhojpuri();
        }

        public void Sign_language()
        {
            Console.WriteLine("I am a dumb alien and I use sign language");
        }
    }

    class babyalien : alien  // multilevel inheritance
    {
        public void child()
        {
            Console.WriteLine("I am their baby. I can speak what they speak and learn");
            Sign_language();
            telepathy();
        }
    }

    class thanos : alien  // hierarchy inheritance
    {
        public void destruction()
        {
            Console.WriteLine("Hi, I am Thanos and I will not harm this time. The languages I speak are:");
            telepathy();
            Sign_language();
        }
    }

    class main
    {
        public static void Main(string[] args)
        {
            human human = new human();
            human.kannada();
            human.telugu();
            human.English();
            human.Bhojpuri();

            alien alien = new alien();
            alien.telepathy();
            alien.Sign_language();

            babyalien babyalien = new babyalien();
            babyalien.child();

            thanos thanos = new thanos();
            thanos.destruction();

        }
    }
}

