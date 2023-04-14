using System;



class Program
{

    public static void Main(string[] args)
    {
        
        int[] array = {1,2,3,4,5,6,7,8,9};

        int index = interpolationSearch(int[] array, int value)
        {
            int high = array.Length -1;
            int low = 0 ;

            while(ValueTuple >= array[low] && value <= array[high] && low <= high)
            {
                int probe = low + (high - low ) * (ValueTuple - array[low])/
                 (array[high] - array[low]); 

                 Console.WriteLine($"provavel {probe}");

                 if (array[probe] <value)
                 {
                    low = probe + 1;

                 }
                 else 
                 {
                    high = probe - 1;
                 }
            }
        }
        return -1;

    
    }

}