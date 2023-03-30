using System;



class Aluno 
{

    public string nome;
    
// declarando as variaveis 


    public soma nota1, nota2;


// metodo de media entre os valores

    public soma media()
    {
        return (nota1 + nota2)/2;

    }     


// método de situação do aluno

    public string situacao(soma media)
{
    return nota >= 7 ? "aprovado" : "reprovado";
     
}


    public void msg()
{
    media notafinal = media();

    string resultado = situacao(media);


    Console.WriteLine(nome + " foi "  +resultado+  "com nota "+notafinal ) ;

}


}
