class Pedido
{
    public int NumeroPedido { get; set; }
    public string NomeDoCliente { get; set; }
    public string Status { get; set; }

    public Pedido (int numeroPedido, string nomeDoCliente)
    {
        NumeroPedido = numeroPedido;
        NomeDoCliente = nomeDoCliente;
        Status = "Pendente";
    }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
        Console.WriteLine($"{NomeDoCliente} Seu pedido: {NumeroPedido} foi atualizado para: {Status}\n");
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Número do pedido: {NumeroPedido}\n" +
            $"Nome do Cliente: {NomeDoCliente}\n" +
            $"Status: {Status}\n");
    }

}