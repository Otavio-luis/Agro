namespace AgroControl.Classes;

public class ProdutoAgricola
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Unidade { get; set; }
    public double Preco { get; set; }
    public double Quantidade { get; set; }

    public ProdutoAgricola()
    {
        Nome = "";
        Unidade = "";
    }

    public ProdutoAgricola(
        int id,
        string nome,
        string unidade,
        double preco)
    {
        Id = id;
        Nome = nome;
        Unidade = unidade;
        Preco = preco;
        Quantidade = 0;
    }

    public void Mostrar()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Unidade: " + Unidade);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Quantidade: " + Quantidade);
    }
}