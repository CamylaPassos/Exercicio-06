// See https://aka.ms/new-console-template for more information

int nota1 = 0;
int nota2 = 0;
int media = 0; 


Console.Write("Digite a primeira nota: ");
nota1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Digite a segunda nota: ");
nota2 = Convert.ToInt32(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (media >= 7 && media < 10)
{
    Console.Write("APROVADO!!");

}
else if (media == 10)
{
    Console.Write("APROVADO com Distinção!!");
}
else
{
    Console.Write("REPROVADO!!");
}


