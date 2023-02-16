int numInt;
int resultado;
Console.WriteLine("Informe um número inteiro, para o qual será calculado a taboada: ");
numInt = int.Parse(Console.ReadLine());
Console.WriteLine($"Esta é a taboada de {numInt}:");
for (int i = 0; i<= 10; i++){
    resultado = numInt * i;
    Console.WriteLine($"{numInt} X {i} = {resultado}");
}
