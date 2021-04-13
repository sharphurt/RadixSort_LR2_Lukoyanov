namespace RadixSort_LR2_Lukoyanov
{
    public static class StringExtensions
    {
        public static int CharValueAt(this string value, int position)
        {
            if (position < 0 || position >= value.Length)
                return 0;

            return value[position];
        }
    }
}