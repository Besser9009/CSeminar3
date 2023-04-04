Console.Clear();
System.Console.Write("Введите число N: ");
int NumN = int.Parse(Console.ReadLine());
int NumX = 1;
while(NumX <= NumN){
    System.Console.WriteLine($"{Math.Pow(NumX, 2)}");
    NumX++;
}