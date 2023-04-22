class program
{
    static void main()
    {
        var calculate = new Calculate(Sum);
        var result = calculate(100,200);
        Console.WriteLine(result);
    }

    static int Sum(int a, int b)
    {
        return a+b; 
    }
}

//de modo gera delegate são tipos 

delegate int Calculate(int x, int y);