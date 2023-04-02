Console.Clear();
System.Console.Write("Введите сумму вклада: ");
double Vklad = Convert.ToDouble(Console.ReadLine());
double OneProcent = Vklad / 100;
if (Vklad < 100 && Vklad > 0){
    double Procent = 5 * OneProcent;
    System.Console.WriteLine($"Общая сумма с %: {Vklad + Procent}");
}
else if (Vklad > 100 && Vklad < 200){
    double Procent = 7 * OneProcent;
    System.Console.WriteLine($"Общая сумма с %: {Vklad + Procent}");
}
else if (Vklad > 200){
    double Procent = 10 * OneProcent;
    System.Console.WriteLine($"Общая сумма с %: {Vklad + Procent}");
}
else{
    System.Console.WriteLine("Вклада нет ):");
}