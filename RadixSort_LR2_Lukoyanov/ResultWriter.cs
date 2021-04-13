using System;
using System.IO;
using System.Text;

namespace RadixSort_LR2_Lukoyanov
{
    public class ResultWriter
    {
        public string Path;

        public ResultWriter(string path)
        {
            Path = path;
            var fs = File.CreateText(path);
            fs.WriteLine("Array Length;Iterations;");
            fs.Close();
        }

        public void WriteResult(SortedWithInfo info)
        {
            try
            {
                using (var sw = File.AppendText(Path))
                {
                    sw.WriteLine($"{info.Array.Length};{info.Iterations};");
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}