class Funcionario
{
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public string Nome { get; set; }
    public string Cargo { get; private set; }

    public void Promover(string novoCargo)
    {
        if (novoCargo.ToLower() == Cargo.ToLower())
        {

            Console.WriteLine($"Desculpe, você não foi promovido.");
        }
        else
        {
            Cargo = novoCargo;
            Console.WriteLine($"Parabéns {Nome}, você foi promovido para {Cargo}!");
        }
    }
}