// tipos anuláveis 

class Program
{
    static void Main()
    {
        int? VariavelNula = 10;
        int? VariavelAuxiliar = VariavelNula;
        VariavelAuxiliar = 50;

/// interrogação no começo (?) define que a variave aceita um vaor nulo


// logo atribuimos o vaor nulo a "VariavelNula"
        VariavelNula = null;


        if(VariavelNula == null)
        {
            Console.WriteLine("A variavel é nula");
        } 


/// captando erros com o c# 

    string Problema = null;

    try
    {
        Console.WriteLine(Problema.Length);
    }
    catch(System.NullReferenceException) // dentro do paranteses (catch) é possivel indicar qual erro é desejado identificar
    {
        Console.WriteLine("o valor é nulo , logo não existe um length");
    }

    }
}