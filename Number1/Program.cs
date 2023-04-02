Console.Clear();
System.Console.Write("Введите значение x, не равное 0: ");
int NumX = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение y, не равное 0: ");
int NumY = int.Parse(Console.ReadLine());
if (NumX > 0 && NumY > 0){
    System.Console.WriteLine("Число находится в первой четверти");
}
else if (NumX < 0 && NumY > 0){
    System.Console.WriteLine("Число находится во второй четверти");
}
else if (NumX < 0 && NumY < 0){
    System.Console.WriteLine("Число находится в третьей четверти");
}
else if (NumX > 0 && NumY < 0){
    System.Console.WriteLine("Число находится в четвёртой четверти");
}
else{
    System.Console.WriteLine("Введено неверное число");
}