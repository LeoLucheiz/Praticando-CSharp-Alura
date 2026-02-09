class Filme
{
    
    // Representa um filme e suas restrições de exibição.
   
    public string Titulo { get; set; }
    public int Classificacao { get; set; }

    // Construtor da classe Filme.
    public Filme(string titulo, int classificacao)
    {
        Titulo = titulo;
        Classificacao = classificacao;
    }

    // Verifica se um usuário tem idade suficiente para assistir ao filme.
    public void PodeAssistir (int IdadeUsuario)
    {
        // Regra de negócio: Se a classificação for menor ou igual à idade, o acesso é permitido

        if (Classificacao <= IdadeUsuario)
        {
            Console.WriteLine($"Você tem {IdadeUsuario} anos, você pode assistir esse filme");
        }
        else
        {
            Console.WriteLine($"Desculpe, você tem {IdadeUsuario} Anos, você não tem idade para assistir esse filme");
        }
    }


}
