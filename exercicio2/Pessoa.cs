using System;

//obj
class Pessoa 
{
    // var
    public string nome;
    public double peso ,  altura;

    

// metodo
    public double calculo()
{
    return peso / (altura * 2) ;
}



    public string situacao(double imc)
{
    string retorno;

    if (imc > 18.5 )
    {
        retorno = "abaixo do normal";
    }
    else if(imc > 25)
    {
        retorno = "Acima do normal";
    }

    else
    {
        retorno = "Normal";
    };

    return retorno;
}


 public void msg()
 {
    double calc = calculo();

    string sit = situacao(calc);


    Console.WriteLine("olá "+nome+"seu IMC é "+calc+ "e sua situacao é"  + sit);
 }

}