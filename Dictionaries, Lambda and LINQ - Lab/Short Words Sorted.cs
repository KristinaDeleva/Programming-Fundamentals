using System;
using System.Linq;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
               {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators,StringSplitOptions.RemoveEmptyEntries);

            var result = words.Where(x => x.Length < 5)
                .OrderBy(a => a).Distinct();

            Console.WriteLine(string.Join(", ", result));
        } 
    }
}
