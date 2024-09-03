using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    /// <summary>
    /// This is the CSharp class that will be used in the LanguageComparison project
    /// </summary>
    
    public class Demos
    {
        public List<string> LoadFile(){
            List<string> outputs = [];
            List<string> lines = File.ReadAllLines(@"C:\temp\test.txt").ToList();
            for(int i = 0; i < lines.Count; i++)
            {
                if(i % 2 == 0)
                {
                    outputs.Add(lines[i]);
                }
                
            }
            return outputs;
        }

        public void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
