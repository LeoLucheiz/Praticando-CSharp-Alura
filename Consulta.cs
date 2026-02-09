using System.Data;

class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }


    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;

    }

    public void Reagendar (DateTime novaData)
    {
        DataConsulta = novaData;
        Console.WriteLine($"\nConsulta reagendada para {DataConsulta}");
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"{NomePaciente} tem uma consulta marcada com {NomeMedico} no dia {DataConsulta}");
    }

}