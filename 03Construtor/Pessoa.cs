class Pessoa
{
    //primeiro construtor
    public Pessoa()
    {
        Console.WriteLine("Hello World!");
    }
    //segundo construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }
    //terceiro construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, voce tem {idade} anos!");
    }
}