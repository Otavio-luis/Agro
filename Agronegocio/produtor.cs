namespace AgroControl.Classes;

public class Produtor : Pessoa
{
    public string CPF { get; set; }

    public Produtor()
    {
        CPF = "";
    }

    public Produtor(
        int id,
        string nome,
        string telefone,
        string cpf)
        : base(id, nome, telefone)
    {
        CPF = cpf;
    }

    public override void Mostrar()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Telefone: " + Telefone);
        Console.WriteLine("CPF: " + CPF);
    }
}