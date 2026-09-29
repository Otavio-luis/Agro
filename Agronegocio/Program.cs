using AgroControl.Classes;
using AgroControl.Services;

namespace AgroControl;

class Program
{
    static List<Produtor> produtores = new List<Produtor>();
    static List<ProdutoAgricola> produtos = new List<ProdutoAgricola>();
    static List<Venda> vendas = new List<Venda>();

    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       AGROCONTROL");
            Console.WriteLine("   SISTEMA DE AGRONEGÓCIO");
            Console.WriteLine("================================");
            Console.WriteLine("1 - Cadastrar produtor");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Registrar venda");
            Console.WriteLine("4 - Listar produtores");
            Console.WriteLine("5 - Listar produtos");
            Console.WriteLine("6 - Listar vendas");
            Console.WriteLine("7 - Consultar produtor");
            Console.WriteLine("8 - Ver estoque");
            Console.WriteLine("9 - Relatório");
            Console.WriteLine("10 - Salvar dados");
            Console.WriteLine("11 - Carregar dados");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            try
            {
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        CadastrarProdutor();
                        break;

                    case 2:
                        CadastrarProduto();
                        break;

                    case 3:
                        RegistrarVenda();
                        break;

                    case 4:
                        ListarProdutores();
                        break;

                    case 5:
                        ListarProdutos();
                        break;

                    case 6:
                        ListarVendas();
                        break;

                    case 7:
                        ConsultarProdutor();
                        break;

                    case 8:
                        VerEstoque();
                        break;

                    case 9:
                        Relatorio();
                        break;

                    case 10:
                        Salvar();
                        break;

                    case 11:
                        Carregar();
                        break;

                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Digite um número válido.");
                Pausar();
                opcao = -1;
            }

        } while (opcao != 0);
    }

    static void CadastrarProdutor()
    {
        Console.Clear();

        Console.WriteLine("=== CADASTRAR PRODUTOR ===");

        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine()!;

        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;

        Produtor produtor = new Produtor(
            produtores.Count + 1,
            nome,
            telefone,
            cpf
        );

        produtores.Add(produtor);

        Console.WriteLine("\nProdutor cadastrado!");
        Pausar();
    }

    static void CadastrarProduto()
    {
        Console.Clear();

        Console.WriteLine("=== CADASTRAR PRODUTO ===");

        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine()!;

        Console.Write("Unidade: ");
        string unidade = Console.ReadLine()!;

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);

        ProdutoAgricola produto = new ProdutoAgricola(
            produtos.Count + 1,
            nome,
            unidade,
            preco
        );

        produtos.Add(produto);

        Console.WriteLine("\nProduto cadastrado!");
        Pausar();
    }

    static void RegistrarVenda()
    {
        Console.Clear();

        Console.WriteLine("=== REGISTRAR VENDA ===");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            Pausar();
            return;
        }

        ListarProdutos();

        Console.Write("Digite o ID do produto: ");
        int id = int.Parse(Console.ReadLine()!);

        ProdutoAgricola? produto =
            produtos.Find(p => p.Id == id);

        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado.");
            Pausar();
            return;
        }

        Console.Write("Quantidade: ");
        double quantidade = double.Parse(Console.ReadLine()!);

        double total = quantidade * produto.Preco;

        Venda venda = new Venda(
            vendas.Count + 1,
            produto.Id,
            quantidade,
            total
        );

        vendas.Add(venda);

        Console.WriteLine(
            "\nVenda registrada! Total: R$ " +
            total.ToString("F2")
        );

        Pausar();
    }

    static void ListarProdutores()
    {
        Console.Clear();

        Console.WriteLine("=== PRODUTORES ===");

        if (produtores.Count == 0)
        {
            Console.WriteLine("Nenhum produtor cadastrado.");
        }

        foreach (Produtor produtor in produtores)
        {
            produtor.Mostrar();
            Console.WriteLine("-------------------------");
        }

        Pausar();
    }

    static void ListarProdutos()
    {
        Console.WriteLine("\n=== PRODUTOS ===");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }

        foreach (ProdutoAgricola produto in produtos)
        {
            produto.Mostrar();
            Console.WriteLine("-------------------------");
        }
    }

    static void ListarVendas()
    {
        Console.Clear();

        Console.WriteLine("=== VENDAS ===");

        if (vendas.Count == 0)
        {
            Console.WriteLine("Nenhuma venda cadastrada.");
        }

        foreach (Venda venda in vendas)
        {
            venda.Mostrar();
            Console.WriteLine("-------------------------");
        }

        Pausar();
    }

    static void ConsultarProdutor()
    {
        Console.Clear();

        Console.WriteLine("=== CONSULTAR PRODUTOR ===");

        Console.Write("Digite o ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Produtor? produtor =
            produtores.Find(p => p.Id == id);

        if (produtor == null)
        {
            Console.WriteLine("Produtor não encontrado.");
        }
        else
        {
            produtor.Mostrar();
        }

        Pausar();
    }

    static void VerEstoque()
    {
        Console.Clear();

        Console.WriteLine("=== ESTOQUE ===");

        foreach (ProdutoAgricola produto in produtos)
        {
            Console.WriteLine(
                produto.Nome +
                " - " +
                produto.Quantidade +
                " " +
                produto.Unidade
            );
        }

        Pausar();
    }

    static void Relatorio()
    {
        Console.Clear();

        Console.WriteLine("=== RELATÓRIO GERAL ===");

        Console.WriteLine(
            "Total de produtores: " +
            produtores.Count
        );

        Console.WriteLine(
            "Total de produtos: " +
            produtos.Count
        );

        Console.WriteLine(
            "Total de vendas: " +
            vendas.Count
        );

        double total = 0;

        foreach (Venda venda in vendas)
        {
            total += venda.ValorTotal;
        }

        Console.WriteLine(
            "Valor total das vendas: R$ " +
            total.ToString("F2")
        );

        Pausar();
    }

    static void Salvar()
    {
        DadosSistema dados = new DadosSistema();

        dados.Produtores = produtores;
        dados.Produtos = produtos;
        dados.Vendas = vendas;

        ArquivoService.Salvar(dados);

        Console.WriteLine("Dados salvos!");
        Pausar();
    }

    static void Carregar()
    {
        DadosSistema? dados =
            ArquivoService.Carregar<DadosSistema>();

        if (dados != null)
        {
            produtores = dados.Produtores;
            produtos = dados.Produtos;
            vendas = dados.Vendas;

            Console.WriteLine("Dados carregados!");
        }
        else
        {
            Console.WriteLine("Nenhum arquivo encontrado.");
        }

        Pausar();
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
}