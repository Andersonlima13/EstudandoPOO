using System;

class Pessoa
{

    private string nome = "eu mesmo";


    public string Pessoa(string nome)
    { 
 // perceeba que , aqui na variavel nome, ele vai exibir o valor instaciado no meu arquivo program, pois ele entende
// que você esta querendo o valor do parametro dado.

// enquanto usar usar this.nome vai chamar diretamente o atributo "eu mesmo"
       Console.WriteLine(nome);
       Console.WriteLine(this.nome);
    }

}