
bool continuar = true;
while (continuar)
{


    Console.WriteLine("--- MEUS EXERCICIOS ALURA ---");
Console.WriteLine("1 - Testar Filmes");
Console.WriteLine("2 - Testar Produtos");
Console.WriteLine("3 - Testar Pedidos");
Console.WriteLine("4 - Testar Consulta");
Console.WriteLine("5 - Testar Produto Digital\n");

string escolha = Console.ReadLine()!;

switch (escolha)
{
    case "1":
        ExecutarExercicioFilme();
        break;
    case "2":
        ExecutarExercicioProduto();
        break;
    case "3":
        ExecutarExercicioPedido();
        break;
    case "4":
        ExecutarExercicioConsulta();
        break;
    case "5":
        ExecutarExercicioProdutoDigital();
        break;
    case "0":
        continuar = false;
        Console.WriteLine("Encerrando o programa...");
        break;
        default:
        Console.WriteLine("Opção inválida");
        break;
}

if (escolha != "0")
{
    Console.WriteLine("\nDeseja escolher outro exercício? (s/n)\n");
    string resposta = Console.ReadLine()!.ToLower();

    if (resposta != "s")
    {
        continuar = false;
        Console.WriteLine("Encerrando o programa...");
    }
}
}


//    CÓDIGO DE FILME
static void ExecutarExercicioFilme()
{


    List<Filme> filmes = new List<Filme>
    {
    new Filme("Exorcista", 18),
    new Filme("Toy Story", 0),
    new Filme("Vingadores", 12),
    new Filme("O Rei Leão", 0),
    new Filme("Pulp Fiction", 16),
    new Filme("Interestelar", 10),
    new Filme("Corra!", 14)
    };

    Console.WriteLine("--- CATALAGO DE FILMES ---");

    foreach (var filme in filmes)
    {
        Console.WriteLine($"Filme: {filme.Titulo} - Classificação Indicativa: {filme.Classificacao}+");
    }

    Console.WriteLine("\nDigite o filme que deseja assistir");
    string escolha = Console.ReadLine()!.ToLower();            // Convertendo a entrada para minúsculas para facilitar a comparação

    Console.WriteLine("Digite sua idade");
    if (int.TryParse(Console.ReadLine(), out int idade))
    {

        Filme filmeEncontrado = filmes.Find(f => f.Titulo.ToLower() == escolha);


        if (filmeEncontrado != null)
        {
            filmeEncontrado.PodeAssistir(idade);                           // Chamando o método para verificar se tem idade para assistir

        }
        else
        {
            Console.WriteLine("Filme não encontrado no catálogo");
        }
    }
    else
    {
        Console.WriteLine("Idade inválida");
    }


}



//    CÓDIGO DE PRODUTO
static void ExecutarExercicioProduto()
{


    Produto produto1 = new Produto("Notebook", 10);
    Produto produto2 = new Produto("Smartphone", 5);
    Produto produto3 = new Produto("Tablet", 8);

    Console.WriteLine($"Seus produtos na loja são de: \n{produto1.QuantidadeDeEstoque} {produto1.Nome}\n" +
        $"{produto2.QuantidadeDeEstoque} {produto2.Nome}:\n" +
        $"{produto3.QuantidadeDeEstoque} {produto3.Nome}\n");

    Console.WriteLine("Digite qual produto deseja retirar");
    string opcao = Console.ReadLine()!.ToLower();
    Console.WriteLine("Qual quantidade dseja retirar ?");
    int quantidadeRetirada = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case "notebook":
            produto1.RetirarEstoque(quantidadeRetirada);
            produto1.QuantidadeAtualNoEstoque();
            break;
        case "smartphone":
            produto2.RetirarEstoque(quantidadeRetirada);
            produto2.QuantidadeAtualNoEstoque();
            break;
        case "tablet":
            produto3.RetirarEstoque(quantidadeRetirada);
            produto3.QuantidadeAtualNoEstoque();
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}


//    CÓDIGO DE PEDIDO
static void ExecutarExercicioPedido()
{

    Pedido Pedido1 = new Pedido(1, "Leonardo");
    Pedido1.ExibirDetalhes();

    Pedido1.AtualizarStatus("Em processamento");
    Pedido1.ExibirDetalhes();

    Pedido1.AtualizarStatus("Enviado");
    Pedido1.ExibirDetalhes();

    Pedido1.AtualizarStatus("Entregue");
    Pedido1.ExibirDetalhes();

}


//    CÓDIGO DE CONSULTA
static void ExecutarExercicioConsulta()
{
    Consulta consulta1 = new Consulta("Léo", "Dr. Marlon", new DateTime(2024, 07, 15, 14, 30, 00));

    consulta1.ExibirResumo();

    Console.WriteLine("Deseja reagendar a consulta? (s/n)");
    string resposta = Console.ReadLine()!.ToLower();

    if (resposta.ToLower() == "s")
    {
        Console.WriteLine("Digite a nova data e hora (ex: 20/10/2026 15:30");
        string entrada = Console.ReadLine()!;

        if (DateTime.TryParse(entrada, out DateTime novaData))
        {

            if (novaData < DateTime.Now)
            {
                Console.WriteLine("\nNão é possivel marcar nessa data, a data já passou.");
                Console.WriteLine("\nConsulta mantida na data original.\n");
            }
            else
            {
                consulta1.Reagendar(novaData);
            }
        }
        else
        {
            Console.WriteLine("Formato de data inválido. Consulta mantida na data original.\n");
        }

    }
    else
    {
        Console.WriteLine("\nConsulta mantida na data original.\n");
    }

    consulta1.ExibirResumo();


}




//    CÓDIGO DE PRODUTO DIGITAL
static void ExecutarExercicioProdutoDigital()
{

    InformacaoTecnica infoTecnica1 = new InformacaoTecnica(500, "Windows"); // Criando as informações técnicas usando o construtor


    InformacaoTecnica infoTecnica2 = new InformacaoTecnica(300, "MacOS");  // Criando as informações técnicas usando o construtor

    ProdutoDigital produtoDigital1 = new ProdutoDigital("Software de Edição de Vídeo", 199.99, infoTecnica1);   // Criando os produtos digitais usando o construtor

    ProdutoDigital produtoDigital2 = new ProdutoDigital("Jogo de Ação", 59.99, infoTecnica2);    // Criando os produtos digitais usando o construtor



    Console.WriteLine("--- PRODUTOS DIGITAIS ---");  // Exibindo os detalhes dos produtos digitais usando o método ExibirDetalhes
    produtoDigital1.ExibirDetalhes();
    produtoDigital2.ExibirDetalhes();
}