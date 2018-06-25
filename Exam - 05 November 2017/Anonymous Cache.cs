using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            while (input != "thetinggoesskrra")
            {
                string[] inputSplit = input.Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (inputSplit.Length > 1)
                {
                    string dataKey = inputSplit[0];
                    long dataSize = long.Parse(inputSplit[1]);
                    string dataSet = inputSplit[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                    data[dataSet][dataKey] = dataSize;
                }

                input = Console.ReadLine();
            }
            if (data.Count > 1)
            {

                var dataSetWithMaxSize = data.
                    OrderByDescending(x => x.Value.Sum(d => d.Value)).First();

                Console.WriteLine($"Data Set: {dataSetWithMaxSize.Key}, " +
                    $"Total Size: {dataSetWithMaxSize.Value.Sum(d => d.Value)}");

                foreach (var item in dataSetWithMaxSize.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}

