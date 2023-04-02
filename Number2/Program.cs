Console.Clear();
System.Console.Write("Введите номер искомой четверти: ");
int Section = int.Parse(Console.ReadLine());
//Первое решение
if (Section == 1){
    System.Console.WriteLine("Диапозон x > 0; y > 0");
}
else if ( Section == 2){
    System.Console.WriteLine("Диапозон x < 0; y > 0");
}
else if ( Section == 3){
    System.Console.WriteLine("Диапозон x < 0; y < 0");
}
else if ( Section == 4){
    System.Console.WriteLine("Диапозон x > 0; y < 0");
}
else{
    System.Console.WriteLine("Неверно введён номер четверти");
}
//Второе решение
switch(Section){
    case 1:
    System.Console.WriteLine("Диапозон x > 0; y > 0");
    break;
    case 2:
    System.Console.WriteLine("Диапозон x > 0; y > 0");
    break;
    case 3:
    System.Console.WriteLine("Диапозон x > 0; y > 0");
    break;
    case 4:
    System.Console.WriteLine("Диапозон x > 0; y > 0");
    break;
    default:
    System.Console.WriteLine("Неверно введён номер четверти");
    break;
}