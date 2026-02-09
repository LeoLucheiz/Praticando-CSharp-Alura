class Produto
{
    public Produto(string nome, int quantidadeDeEstoque)
    {
        Nome = nome;
        QuantidadeDeEstoque = quantidadeDeEstoque;
    }

    public string Nome { get; set; }
    public int QuantidadeDeEstoque { get; private set; }


    public void RetirarEstoque (int quantidade)     {
        if (quantidade > QuantidadeDeEstoque)
        {
            Console.WriteLine($"Desculpe, não há estoque suficiente para retirar {quantidade} unidades de {Nome}.");
        }
        else
        {
            QuantidadeDeEstoque -= quantidade;
            Console.WriteLine($"Foram retiradas {quantidade} unidades de {Nome}.");
        }
    }

    public void QuantidadeAtualNoEstoque()
    {
        Console.WriteLine($"A quantidade atual em estoque de {Nome} é: {QuantidadeDeEstoque}");
    }


}