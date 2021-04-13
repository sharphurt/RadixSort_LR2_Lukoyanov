using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RadixSort_LR2_Lukoyanov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sorter = new RadixStringSort();
            var massTask =
                (Experiments) new XmlSerializer(typeof(Experiments)).Deserialize(File.OpenText("MassTask.xml"));
            var generator = new ArrayGenerator();

            foreach (var experiment in massTask.ExperimentsArray)
            {
                foreach (var node in experiment.Nodes)
                    for (var i = 0; i < node.Repeats; i++)
                    {
                        var arrays = generator.Generate(node);
                        var writer = new ResultWriter($"output_{experiment.Name}_{node.Name}_{i}.csv");

                        foreach (var array in arrays)
                        {
                            var result = sorter.Sort(array);
                            writer.WriteResult(result);
                        }

                        Console.WriteLine($"Node {node.Name}_{i} finished");
                    }

                Console.WriteLine($"Experiment {experiment.Name} finished");
            }
        }
    }
}