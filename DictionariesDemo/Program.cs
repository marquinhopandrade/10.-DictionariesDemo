using System;
using System.Collections.Generic;
namespace DictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>(){            
                { 1, "one"},            
                { 2, "two"},
                { 3, "three"}, 
            };            

            Console.WriteLine("Hello World!");
        }
    }
}
