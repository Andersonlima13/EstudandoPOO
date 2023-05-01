using System;

abstract class Imposto
{

// virtual -> indica que o metodo pode ter o valor sobreescrito , com aqui é um valor padrão,
// logo os outros metodos irão altera-lo 
    public virtual void Alimentacao(double salario)
    {
     Console.WriteLine("desconto padrão alimentação de R$ " + (salario * 0.10));   
    }

    public virtual void Transporte(double salario)
    {
        Console.WriteLine("desconto padrão transporte de  R$ " + (salario * 0.06));   

    }
}