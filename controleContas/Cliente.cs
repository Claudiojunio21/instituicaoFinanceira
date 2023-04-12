using System;
using System.Text.RegularExpressions;

//Crie uma nova classe Cliente
public class Cliente
{
    private string nome;
    private string cpf;
    private int anoNascimento;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set
        {
            if (value.Length == 11 && Regex.IsMatch(value, "^[0-9]*$")) //o cliente deve ter mais que 18 anos
            {
                cpf = value;
            }
            else
            {
                Console.WriteLine("CPF inválido. O CPF deve ter 11 dígitos e não pode conter pontos ou traços.");
            }
        }
    }

    public int AnoNascimento
    {
        get { return anoNascimento; }
        set
        {
            if (DateTime.Now.Year - value >= 18)
            {
                anoNascimento = value;
            }
            else
            {
                Console.WriteLine("Idade inválida. O cliente deve ter mais de 18 anos.");
            }
        }
    }

    public string IdadeRomana(int anoNascimento)
    {
        int idade = DateTime.Now.Year - anoNascimento;
        string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] milhares = { "", "M", "MM", "MMM" };

        string romano = milhares[(idade / 1000) % 10] + centenas[(idade / 100) % 10] + dezenas[(idade / 10) % 10] + unidades[idade % 10];

        return romano;
        //Não sei a idade de um Orc bem velho :/
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + Cpf);
        Console.WriteLine("Ano de Nascimento: " + anoNascimento);
        Console.WriteLine("Idade Romana: " + IdadeRomana(anoNascimento));
    }
}