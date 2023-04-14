using System ;

abstract class Padrão
{


 // valor abstract , logo obrigatório
    public abstract void Emprestimo(double valor);

    public void calculo(double valor , double taxa)
    {
        Console.WriteLine("valor a ser obtido " + (valor * taxa));
    }

}