using System;

class PessoaFisica : Padrão
{
    public override void Emprestimo(double valor)
    {
        Console.WriteLine("taxa para pessoa fisica de " + (valor * 0.1));
    }
}