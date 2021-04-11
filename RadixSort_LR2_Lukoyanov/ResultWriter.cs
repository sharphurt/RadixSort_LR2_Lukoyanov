using System;
using System.IO;
using System.Text;

namespace RadixSort_LR2_Lukoyanov
{
    public static class ResultWriter
    {
        public static void WriteResult(SortedWithInfo info, string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                using (StreamWriter sw = File.CreateText(path))    
                { 
                    sw.WriteLine("Length,Iterations");
                    sw.WriteLine($"{info.Array.Length},{info.Iterations}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}