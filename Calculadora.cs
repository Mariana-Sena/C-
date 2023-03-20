

double num1 = 0;
double num2 = 0;

Console.WriteLine("Calculadora Console em C#\r");
Console.WriteLine("-----------------------------\n");

Console.WriteLine("Digite um número e pressione enter");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um número e pressione enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Selecione uma das opções:");
Console.WriteLine("\ta - Soma");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write("Qual è a sua opção? ");

switch(Console.ReadLine())
{
  case "a":
  Console.WriteLine("$ Resultado: {num1} + {num2} =" + (num1 + num2));
  break;

  case "s":
  Console.WriteLine("$ Resultado: {num1} - {num2} =" + (num1 - num2));
  break;

  case "m":
  Console.WriteLine("$ Resultado: {num1} * {num2} =" + (num1 * num2));
  break;

  case "d":
  while(num2 == 0)
  {
    Console.WriteLine("Erro - Divisão por zero");
    num2 = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("$ Resultado: {num1} / {num2} =" + (num1 / num2));
  break;

  default:
  Console.WriteLine("Opção Inválida!");
  break;
}
Console.WriteLine("Pressione qualquer tecla para fechar a Calculadora Console App\n");
Console.ReadKey();






