class ProdutoDigital
{
    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }



    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: R${Preco}\nTamanho: {InfoTecnica.TamanhoMB} MB\nSistema Operacional: {InfoTecnica.SistemaOperacional}\n");
    }
}