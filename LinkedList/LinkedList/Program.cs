using System;
using System.Collections;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            Console.WriteLine(test.Contains(2));
            Console.WriteLine(test.Contains(5));
            Console.WriteLine(test[0]);
            Console.WriteLine(test[2]);
            // Console.WriteLine(test[5]);

            ICollection<String> collection = new LinkedList<Object>();
            collection.Add("");

            IIndex<Object> indexCollection = new LinkedList<String>();
            Console.WriteLine(indexCollection[0].GetType());
        }
    }
}
