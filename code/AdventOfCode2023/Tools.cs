using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Tools
    {
        public static string[] TextToString(string path) 
        {
            
            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }
    }
}
