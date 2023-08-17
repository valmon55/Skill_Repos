using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Collections
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText(@"N:\!!!HLAM!!!\KRIVOSINNYY\!\13_6_1_Text.txt"))
            {
                string s = sr.ReadToEnd();
                char[] delimiters = { ' ', '\r', '\n' };
                string[] w = s.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(w.Length);
                //Regex r = new Regex(@"([a-zA-Zа-яА-Я])+");
                //Match m;// = Match();
                //m = r.Match(s);
                //Console.WriteLine(m.Length);
                Console.ReadLine();
                //Console.WriteLine(s);
            }
        }
    }
}
