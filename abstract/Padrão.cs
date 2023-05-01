using System ;

abstract class Padrão
{
//Classe abstrata: é uma classe restrita que não pode ser utilizada para criar objetos (para acessá-la, deve ser herdada de outra classe).//

//Método abstrato: só pode ser usado em uma classe abstrata e não possui corpo. O corpo é fornecido pela classe derivada (herdada de).
 
// valor abstract , logo obrigatório
    public abstract void Emprestimo(double valor);

    public void calculo(double valor , double taxa)
    {
        Console.WriteLine("valor a ser obtido " + (valor * taxa));
    }

}