


    
// permite criar um tipo de classe o qual teremos valores apenas de leitura , logo um grupo de constantes
    public class Enumerador
    {
        public enum MesesDoAno
        {
            janeiro,fevereiro, março, abril, maio , junho , julho , agosto, setembro, outubro , novembro
        }

     public void ExibirMes(MesesDoAno Mes)
     {
     Console.WriteLine($" O mês selecionado foi {Mes}");
     }


    }
   
