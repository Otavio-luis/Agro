namespace AgroControl.Classes;

public class DadosSistema
{
    public List<Produtor> Produtores { get; set; }
    public List<ProdutoAgricola> Produtos { get; set; }
    public List<Venda> Vendas { get; set; }

    public DadosSistema()
    {
        Produtores = new List<Produtor>();
        Produtos = new List<ProdutoAgricola>();
        Vendas = new List<Venda>();
    }
}