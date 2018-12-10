using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedListLab
{
    public static class LinkedListExtensions
    {

        public static bool RemoveAt<T>(this LinkedList<T> list, int number)
        {
            var index2 = number - 1;

            LinkedListNode<T> NodeOne = list.First;
            for (int i = 0; i <= index2 && NodeOne != null; i++)
            {
                if (i != index2)
                {
                     var Node = NodeOne.Next; 
                    continue;
                }
                list.Remove(NodeOne);
            }
            return false; 
        }

        public static void PrintReverse<T>(this LinkedList<T> list)
        {
            for (int j = list.Count - 1; j >= 0; j--)
            {
                Console.WriteLine(list.ElementAt(j));
            }
        }

        public static bool  InsertAt<T>(this LinkedList<T> list, int index, T o)
        {
            return false; 
        }
    }


    public static class StringExtension
    {
        public static string ToCamelCase(this string value)
        {
            return string.Empty;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 1, 1, 2, 4, 7, 7, 8, 9, 5 };
            var newlist = new LinkedList<int>(numbers);



            Console.WriteLine("list in reverse order");
            newlist.PrintReverse();
            Console.WriteLine();
            Console.ReadLine();


            Console.WriteLine("Please suggest a position in the array to remove");
            Console.ReadLine(); 
            newlist.RemoveAt(2);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}