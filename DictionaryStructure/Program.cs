using System;

namespace DictionaryStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            Console.WriteLine("Please enter you key and value respesctively: ");
            Console.WriteLine("Press '0' to exit.");

            while (true)
            {
                int key;
                string value;
                key = Convert.ToInt32(Console.ReadLine());
                if (key == 0)
                {
                    break;
                }
                value = Console.ReadLine();
                myDictionary.Add(key, value);

                break;
            }
            Console.WriteLine(myDictionary.Length()); // to control if it is working properly, or not?
            
        }
    }
}
