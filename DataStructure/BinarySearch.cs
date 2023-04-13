using System;

class Program
{

    public static void Main(string[] args)
    {

        int[] array = new int[100];
        int target = 42;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        //int index = Array.BinarySearch(array, target);
          int index = BinarySearch(array, target);

        if(index == -1)
        {
          Console.WriteLine("element not found");
        }
      else
      {
        Console.WriteLine($"element found at {index}");  
      }
    }

    private static int BinarySearch(int[] array , int target)
    {
      int low = 0;
      int high = array.Length -1;

      while(low <= high)
      {
        int middle = low + (high - low)/ 2; 
        int value = array[middle];

        Console.WriteLine($" meio é igual a : {value}");

        if(value < target) low = middle + 1;
        else if(value > target) high = middle - 1;
        else return middle; 

        
        
      
          
        }

      return - 1;
      }
    }
  
