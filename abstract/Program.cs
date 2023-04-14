using System;

namespace estudandopoo
{

    class Program 
    {

        static void Main(String [] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Emprestimo(1000);

            
            PessoaJuridica pj = new PessoaJuridica();
            pj.Emprestimo(1000);
        }
    }
}