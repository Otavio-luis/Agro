namespace AgroControl.Classes;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Pessoa()
    {
        Nome = "";
        Telefone = "";
    }

    public Pessoa(int id, string nome, string telefone)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Telefone: " + Telefone);
    }
}