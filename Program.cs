// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("A data corrente " + DateTime.Now);

int idade = 17;
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade!");
}
else
{
    Console.WriteLine("Você é menor de idade!");
}

int mes = 2;
switch(mes)
{
    case 1:
        Console.WriteLine("O mês é Janeiro!");
        break;
    case 2:
        Console.WriteLine("O mês é Fevereiro!");
        break;
    case 3:
        Console.WriteLine("O mês é Março!");
        break;
    case 4:
        Console.WriteLine("O mês é Abril!");
        break;
    case 5:
        Console.WriteLine("O mês é Maio!");
        break;
    case 6:
        Console.WriteLine("O mês é Junho!");
        break;
    case 7:
        Console.WriteLine("O mês é Julho!");
        break;
    case 8:
        Console.WriteLine("O mês é Agosto!");
        break;
    case 9:
        Console.WriteLine("O mês é Setembro!");
        break;
    case 10:
        Console.WriteLine("O mês é Outubro!");
        break;
    case 11:
        Console.WriteLine("O mês é Novembro!");
        break;
    case 12:
        Console.WriteLine("O mês é Dezembro!");
        break;  
    default: 
        Console.WriteLine("Mês inválido");
        break;
}


int numero = -1;
while (numero != 10)
{
    Console.Write("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero < 10)
    {
        Console.WriteLine("Você errou, tente um número maior.");
    }
    else if (numero > 10)
    {
        Console.WriteLine("Você errou, tente um número menor.");
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou!"); 
    }
}


int contador = 15;
do{
    Console.WriteLine("O contador vale: " + contador);
    contador++;
} 
while (contador <= 10);
 

for (int i=1; i<=10; i++)
{
    Console.WriteLine("A variável i agora vale: " + i);
}