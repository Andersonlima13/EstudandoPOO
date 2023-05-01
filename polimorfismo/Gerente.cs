using System;

class Gerente : Imposto
{

// o override faz referencia com o "virtual" aqui indicamos que o metodo vai sobreescrever algo 
    public override void Alimentacao(double salario) 
    {
        Console.WriteLine("desconto do gerente é  de  R$ " + (salario * 0.15));   
    }

    
    public override void Transporte(double salario) 
    {
        Console.WriteLine("desconto do transporte no gerente é  de  R$ " + (salario * 0.15));   
    }
   
}