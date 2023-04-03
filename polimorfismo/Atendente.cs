using System;



// os : depois do objeto significa um objeto extendido , nesse caso , de imposto
class Atendente : Imposto
{

    public override void Alimentacao(double salario) 
    {
        Console.WriteLine("desconto padrão de  R$ " + (salario * 0.12));   
    }
}