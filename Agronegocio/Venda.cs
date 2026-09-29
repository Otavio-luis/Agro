namespace AgroControl.Classes;

public class Venda
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public double Quantidade { get; set; }
    public double ValorTotal { get; set; }

    public Venda()
    {
    }

    public Venda(
        int id,
        int produtoId,
        double quantidade,
        double valorTotal)
    {
        Id = id;
        ProdutoId = produtoId;
        Quantidade = quantidade;
        ValorTotal = valorTotal;
    }

    public void Mostrar()
    {
        Console.WriteLine("Venda: " + Id);
        Console.WriteLine("Produto ID: " + ProdutoId);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine(
            "Valor: R$ " +
            ValorTotal.ToString("F2")
        );
    }
}