namespace TestProject
{
    internal class Program
    {
        public static void SwapMinMax(int[] array)
        {
            if (array == null || array.Length == 0) return;

            int minIndex = 0, maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            int temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;
        }

        static void Main(string[] args)
        {
            int[] data = [1, 2, 3, 4, 0, -1];
            SwapMinMax(data);
        }
    }
}
