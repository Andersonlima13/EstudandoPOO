using System.Text.Json;


// serializando com json , transformando nosso objeto em json
class Promama
{
    static void Main()
    {
        Bank account = new Bank("anderson", 100);
        string json = JsonSerializer.Serialize(account);

        Console.WriteLine(json);
    }


    public class Bank
{
    public string name;
    public int quantity;
    public Bank(string name, int quantity)
    {
      

    }
}
    
}

