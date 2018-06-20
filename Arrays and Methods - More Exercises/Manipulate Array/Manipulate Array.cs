using System;
using System.Linq;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                switch (commands[0])
                {
                    case "Reverse":
                        Reverse(arr);
                        break;
                    case "Distinct":
                        arr = RemoveDuplicates(arr);
                        break;
                    case "Replace":
                        Replace(arr, commands[1], commands[2]);
                        break;
                        
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void Replace(string[] arr, string stringIndex, string newString)
        {
            int index = int.Parse(stringIndex);
            arr[index] = newString;
        }

        static string[] RemoveDuplicates(string[] arr)
        {
            int distinct = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.IsNullOrEmpty(arr[i]))
                {
                    continue;
                }
                else
                {
                    distinct++;
                }
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i == k)
                    {
                        continue;
                    }
                    if (arr[i].Equals(arr[k]))
                    {
                        arr[k] = string.Empty; // arr[k] = null;
                    }
                }
            }
            if (arr.Length == distinct)
            {
                return arr;
            }
            string[] distinctElements = new string[distinct];

            for (int i = 0, j=0; i < arr.Length; i++)
            {
                if (!string.IsNullOrEmpty(arr[i]))
                {
                    distinctElements[j++] = arr[i];
                }
            }

            System.Diagnostics.Debug.Assert(distinctElements.Length == distinct);
            return distinctElements;
        }

        static void Reverse(string[] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - i -1];
                arr[arr.Length - i - 1] = temp;
            }
        }
    }
}
