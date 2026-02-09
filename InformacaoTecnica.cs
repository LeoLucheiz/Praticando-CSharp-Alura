class InformacaoTecnica
{
    public InformacaoTecnica(double tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }

    public double TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }
}