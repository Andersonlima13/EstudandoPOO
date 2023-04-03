using System;

class Imposto
{

// virtual -> indica que o metodo pode ter o valor sobreescrito , com aqui é um valor padrão,
// logo os outros metodos irão altera-lo 
    public virtual void Alimentacao(double salario)
    {
     Console.WriteLine("desconto padrão de  R$ " + (salario * 0.1));   
    }

    public void Transporte(double salario)
    {
        Console.WriteLine("desconto padrão de  R$ " + (salario * 0.06));   

    }
}