Console.Clear();
//Первое решение
System.Console.Write("Введите число N: ");
int NumN = int.Parse(Console.ReadLine());
int NumX = 1;
while(NumX <= NumN){
    System.Console.Write($"{Math.Pow(NumX, 2)} ");
    NumX++;
}
System.Console.WriteLine(" ");
//Второе решение
System.Console.Write("Введите число N: ");
int NumZ = int.Parse(Console.ReadLine());
for (int NumR = 1; NumR <= NumZ; NumR++){
    Console.Write($"{Math.Pow(NumR, 2)} ");
}