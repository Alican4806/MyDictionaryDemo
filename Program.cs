using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Dictionary = new MyDictionary<int, string>();
            Dictionary.Add(48, "Muğla");


            Dictionary.List();
        }
    }
}
