

public class Program
{
    static void Main(String [] args)
    {
        int[] array = {9,1,8,55,11,55,22};

        int index = LinearSearch(array, 55);
        if (index != -1)
        {
            Console.WriteLine($"Elemento encontrado na posição {index}" ); 
        }else
        {
             Console.WriteLine("Elemento nao encontrado");
        }

    static int LinearSearch(int[] array , int value)
    {
        for (int i = 0 ; i < array.Length; i++)
        {
            if(array[i] == value)
            {
                return i;
            }
 
        } 
    return -1 ;
    }
    }
}