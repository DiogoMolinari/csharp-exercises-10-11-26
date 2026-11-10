/*Exercício 4: Faça um programa que leia um número inteiro e mostre 
todos os números primos até ele, inclusive ele (caso seja primo).*/

int number = 0;

Console.Write("Digite um número inteiro para ser nosso critério de parada: ");
number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    bool Prime = true;

    for(int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            Prime = false;
            break;
        }
    }

    if (Prime == true)
    {
        Console.WriteLine(i);
    }
}
