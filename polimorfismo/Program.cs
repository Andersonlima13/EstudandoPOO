using System;

namespace atributo
{

    class Program 
    {

        static void Main(String [] args)
        {
        // Instância de estagiario            
           Imposto objE = new Estagiario();
           objE.Alimentacao(1000);
           objE.Transporte(1000);

           Imposto objG = new Gerente();
           objE.Alimentacao(5000);
           objE.Transporte(5000);

           Imposto objA = new Atendente();
           objE.Alimentacao(2000);
           objE.Transporte(2000);
            


        }
    }
}