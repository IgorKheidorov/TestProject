namespace Program
{
    public class Program 
    {
        public static void SwapMinMax(int[] array)
        {
            if (array == null || array.Length == 0) return;

            int minIndex = 0, maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
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

        public static void Main()
        {
            int[] data = [1, 2, 5, -10, 0];
            SwapMinMax(data);        
        }

    }

}