Console.WriteLine("*************************************");
Console.WriteLine("************ CALCULADORA ************");
Console.WriteLine("*************************************\n");

Console.WriteLine("Digite o caractere desejado:(+ - * /)");
char caracter = char.Parse(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero: ");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
double n2 = double.Parse(Console.ReadLine());

if(caracter == '+')
{
    Console.WriteLine($"A soma do primeiro e segundo número é: { n1+n2}\n\n");
}
if(caracter == '-')
{
    Console.WriteLine($"A subtração de primeiro e segundo número é: {n1-n2}\n\n");
}
if(caracter == '*')
{
    Console.WriteLine($"A multiplicação do primeiro e segundo número é: {n1 * n2}\n\n");
}
else if(caracter == '/')
{
    Console.WriteLine($"A divisão dos primeiro e segundo número é: {n1/n2}\n\n");
}


Console.WriteLine("********* Project by Penga **********\n");