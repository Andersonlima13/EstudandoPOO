
class Pessoa 
{

    private string nome;



// metodos get e set sao publicos , o nome precisa ser igual (padrao) a variavel
// porem com letra maiuscula


// se quiser apenas acessar atributos , apenas mande o dado para "set" 
    public string Nome
{
    get{return nome ;}
    set{nome = value;}
}
}