class List
{
 
 
 // uso parecido com arrays , porem dando a vantagem de possuir os metodos de remove e add 
    static void Main()
    {
       List<int> numbers = new List<int> {1,2,3,4,5};

      
        numbers.Remove(1);
        numbers.Add(100);

       foreach(int number in numbers)
       {
        Console.WriteLine(number);
       }

       

    }
}