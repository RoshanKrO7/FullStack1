using System;
using System.Collections.Generic;

public class One
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("RamKrishna");
        names.Add("Swarnim");
        names.Add("Sayeed");
        names.Add("Roshan");
        names.Add("Yashica");
        names.Add("Deepshikha");
        names.Add("Thushani");
        names.Add("Hema");
        names.Add("Shruti");
        foreach (var i in names)
        {
            Console.WriteLine(i);
        }
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Ramkrishna", 21);
        ages.Add("Swarnim", 21);
        ages.Add("Sayeed", 22);
        ages.Add("Roshan", 22);
        ages.Add("Yashica", 21);
        ages.Add("Deepshiskha", 21);
        foreach (var k in ages)
        {
            Console.WriteLine(k);
        }
        Hastable table1 = new Hastable();
        table1.add(1, "abc");
        table1.add("def", 2);
        table1.add(3, 4);
        Console.WriteLine("Key and Value pairs from table1");
        foreach (var i in table1)
        {
            Console.Write(i);
        }
        ArrayList1 list1 = new ArrayList1();
        list1.add("Roshan");
        list1.add("Swarnim");
        list1.add("Sayeed");
        list1.add("Ramkrishna");
    }

}
