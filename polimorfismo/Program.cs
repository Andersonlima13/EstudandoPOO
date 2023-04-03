using System;

namespace atributo
{

    class Program 
    {

        static void Main(String [] args)
        {
        // Instância de estagiario            
           Imposto objE = new Estagiario();
           objE.Alimentacao(100);
           objE.Transporte(50);

           Imposto objG = new Gerente();
           objE.Alimentacao(400);
           objE.Transporte(200);

           Imposto objA = new Atendente();
           objE.Alimentacao(300);
           objE.Transporte(100);
            


        }
    }
}