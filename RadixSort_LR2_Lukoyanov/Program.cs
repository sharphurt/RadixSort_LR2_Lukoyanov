namespace RadixSort_LR2_Lukoyanov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int limit = 150;
            const int repeat = 1;
            var sorter = new RadixStringSort();
            
            for (var i = 0; i <= limit; i++)
            for (var j = 0; j < repeat; j++)
            {
                var sortedArrayWithInfo = sorter.SortWithInfo(Utils.GenerateRandomArray(i));
                ResultWriter.WriteResult(sortedArrayWithInfo, $"/Output/output_{i}_{j}.csv");
            }
        }
    }
}