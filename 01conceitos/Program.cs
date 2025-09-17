//Exemplo 01
Pessoa objeto1 = new Pessoa();
objeto1.Nome = "Thainá";
//objeto1.Apresentacao();

//Exemplo02
Pessoa objeto2 = new();
objeto2.Nome = "Sandro";
//objeto2.Apresentacao();

//Exemplo3
Pessoa objeto3 = new()
{
    Nome = "Fabiana",
    Idade = 23
};
//Verifica a idade usando o método criado na classe Pessoa
string retorno = objeto3.VerificarIdade();
Console.WriteLine($"A pessoa é {retorno}");
