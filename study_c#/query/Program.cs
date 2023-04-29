class Query
{

    /// uma maneira de fazer consultas como no sql , porem dentro de codigo c#
    static void Main()
    {
        int[] numbers = {1,2,5,4,9,45,55,4};

        var query = numbers.Where(number => number < 10);

        Console.WriteLine(numbers);
    }
}