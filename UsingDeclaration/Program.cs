using System;
using System.Collections.Generic;
using System.IO;

namespace UsingDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Using Declaration in C# 8.0");
            List<string> lstLines = new List<string>();
            lstLines.Add("1 is One");
            lstLines.Add("2 is Two");
            lstLines.Add("3 is Three");
            WriteToFile(lstLines);
            Console.ReadKey();
        }

        static void WriteToFile(IEnumerable<string> lstLines)
        {
            //Using Declaration 
            using var file = new StreamWriter("G:\\Demo\\DemoUsingDeclaration.txt");
            
                foreach (var line in lstLines)
                {
                    file.WriteLine(line + Environment.NewLine);
                }
            
            
        }
    }
}
