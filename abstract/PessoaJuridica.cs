using System;

class PessoaJuridica : Padrão
{
    public override void Emprestimo(double valor)
    {
        Console.WriteLine("taxa para pessoa Juridica de " + (valor * 0.2));
    }
}