using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines;
            string[] studentlines;

            lines = System.IO.File.ReadAllLines(@"File.txt");

            studentlines = lines.Where(line => line.StartsWith("01")).ToArray();

            string data1 = "01Jonh Smith          016Some place in NY, USA         01/01/2014L01";


            StudentData student = FixedLengthFormatter.ParseString<StudentData>(data1);

            Console.ReadKey();
        }
    }
}
