/* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
velha. */

using Recapitulacao_exec_orient_obj_1;

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Informe o nome da primeira pessoa:");
p1.Nome = Console.ReadLine();
Console.WriteLine("Informe a idade:");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o nome da segunda pessoa:");
p2.Nome = Console.ReadLine();
Console.WriteLine("Informe a idade:");
p2.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: " + p1.Nome);
Console.WriteLine("Idade: " + p1.Idade);

Console.WriteLine("Dados da segunda pessoa:");
Console.WriteLine("Nome: " + p2.Nome);
Console.WriteLine("Idade: " + p2.Idade);

if(p1.Idade > p2.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
}
