using System;

class Gerente : Imposto
{

// o override faz referencia com o "virtual" aqui indicamos que o metodo vai sobreescrever algo 
    public override void Alimentacao(double salario) 
    {
        Console.WriteLine("desconto gerente  de  R$ " + (salario * 0.15));   
    }
}