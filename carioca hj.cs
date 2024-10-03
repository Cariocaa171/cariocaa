// See https://aka.ms/new-console-template for more information

using System;


public class Pessoa
{
    
    private string nome;
    private int idade;
    private string telefone;
    private string endereco;
    private string email;

    
    public string Nome
    {
        get { return nome; } // Retorna o valor do nome
        set
        {
            
            if (!string.IsNullOrWhiteSpace(value))
            {
                nome = value; // Define o novo nome se for válido
            }
            else
            {
                
                throw new ArgumentException("Nome não pode ser vazio.");
            }
        }
    }

   
    public int Idade
    {
        get { return idade; } 
        set
        {
            
            if (value >= 0)
            {
                idade = value; 
            }
            else
            {
                
                throw new ArgumentException("Idade não pode ser negativa.");
            }
        }
    }

   
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    
    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    
    public string Email
    {
        get { return email; }
        set
        {
            
            if (!string.IsNullOrWhiteSpace(value))
            {
                email = value; 
            }
            else
            {
                
                throw new ArgumentException("Email não pode ser vazio.");
            }
        }
    }

    
    public Pessoa(string nome, int idade, string telefone, string endereco, string email)
    {
        Nome = nome;
        Idade = idade;
        Telefone = telefone;
        Endereco = endereco;
        Email = email;
    }
}


public class Program
{
    
    public static void Main(string[] args)
    {
        
        Pessoa pessoa = new Pessoa("carioca", 25, "333-333", "Rua A, 155", "cariocca@exemplo.com");

        
        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Telefone: {pessoa.Telefone}");
        Console.WriteLine($"Endereço: {pessoa.Endereco}");
        Console.WriteLine($"Email: {pessoa.Email}");

        
        try
        {
            
            pessoa.Idade = -5;
        }
        catch (ArgumentException e)
        {
            
            Console.WriteLine(e.Message);
        }

        try
        {
            
            pessoa.Nome = "";
        }
        catch (ArgumentException e)
        {
            
            Console.WriteLine(e.Message);
        }
    }
}














































