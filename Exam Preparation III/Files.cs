using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class Files
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Dictionary<string, long>> storage = new Dictionary<string, Dictionary<string, long>>();

            //int n = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            //    string[] fileData = input.Last().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //    string root = input[0];
            //    string fileName = fileData[0];
            //    long fileSize = long.Parse(fileData[1]);

            //    if (storage.ContainsKey(root))
            //    {
            //        if (storage[root].ContainsKey(fileName))
            //        {
            //            storage[root][fileName] = fileSize;
            //        }
            //        else
            //        {
            //            storage[root].Add(fileName, fileSize);
            //        }
            //    }
            //    else
            //    {
            //        storage.Add(root, new Dictionary<string, long> { { fileName, fileSize } });
            //    }
            //}

            //string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string extension = command[0];
            //string dir = command[2];

            //var sorted = storage.Where(x => x.Key == dir).OrderByDescending(f => f.Value.Values);

            //foreach (var r in sorted)
            //{
            //    foreach (var item in r.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
            //    {
            //        if (item.Key.Split('.').Last() == extension)
            //        {
            //            Console.WriteLine($"{item.Key} - {item.Value} KB");
            //            counter++;
            //        }
            //    }
            //}
            //if (counter == 0)
            //{
            //    Console.WriteLine("No");
            //}

            Dictionary<string, Dictionary<string, BigInteger>> readFiles = new Dictionary<string, Dictionary<string, BigInteger>>();
            long numberFiles = int.Parse(Console.ReadLine());
            long counter = 0;
            for (int i = 0; i < numberFiles; i++)
            {
                var file = Console.ReadLine().Split('\\');
                string root = file[0];
                string fileAndSize = file[file.Length - 1];
                var splitedFileSize = fileAndSize.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string fileNameExt = splitedFileSize[0];

                BigInteger fileSize = BigInteger.Parse(splitedFileSize[1]);

                if (readFiles.ContainsKey(root))
                {
                    readFiles[root][fileNameExt] = fileSize;
                }
                else
                {
                    readFiles.Add(root, new Dictionary<string, BigInteger>());
                    readFiles[root][fileNameExt] = fileSize;
                }
            }
            var searchInput = Console.ReadLine().Split();
            string rootWanted = searchInput[2];
            string extWanted = searchInput[0];
            if (!readFiles.ContainsKey(rootWanted))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in readFiles[rootWanted].OrderByDescending(x => x.Value).ThenBy(k => k.Key))
                {
                    var extentionAndName = file.Key.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var extention = extentionAndName[1];
                    var name = extentionAndName[0];
                    if (extWanted == extention)
                    {
                        counter++;
                        Console.WriteLine($"{name}.{extention} - {file.Value} KB");
                    }

                }
                if (counter == 0)
                    Console.WriteLine("No");
            }

            // i dvete sa za 100tochki
        }
    }
}
