using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp8Pro
{
    public class UsingDecleration
    {
        public static int ConvertFiles() 
        {
            int output = 0;
            using var inputFile = new StreamReader(@"D:\InputFile.txt");
            using var outputFile = new StreamWriter(@"D:\OutputFile.txt");
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output += 1;
            }

            //int output = 0;
            //using (var inputFile = new StreamReader(@"D:\InputFile.txt"))
            //{
            //    using (var outputFile = new StreamWriter(@"D:\OutputFile.txt"))
            //    {
            //        string line;
            //        while ((line = inputFile.ReadLine()) != null)
            //        {
            //            outputFile.WriteLine(line);
            //            output += 1;
            //        }
            //    }
            //}
            return output;
        }
    }
}
