namespace DesafioProjetoHospedagem.Models;

public class Guest
{
    public Guest() { }

    public Guest(string nome)
    {
        Nome = nome;
    }

    public Guest(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}