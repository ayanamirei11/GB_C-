int a,b;
String str;

Console.WriteLine("Введите число");
str=Console.ReadLine();
a=int.Parse(str);

b=a%7;
switch(b){
    case 1:
        Console.WriteLine("Понидельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("неправильные данные");
        break;
}

Console.ReadLine();