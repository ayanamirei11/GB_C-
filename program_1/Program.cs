int a,b;
String str;

Console.WriteLine("Введите число");
str=Console.ReadLine();
a=int.Parse(str);
Console.WriteLine("Введите квадрат этого числа");
str=Console.ReadLine();
b=int.Parse(str);

if (a*a==b){
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}
Console.ReadLine();