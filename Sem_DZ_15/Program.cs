Console.WriteLine("Является ли указанный день выходным?");
Console.Write("Введите номер дня недели ");
int x = Convert.ToInt32(Console.ReadLine());
if ( x == 1 )
{
    Console.WriteLine("понедельник - нет");
}
if ( x == 2 )
{
    Console.WriteLine("вторник - нет");
}
if ( x == 3 )
{
    Console.WriteLine("среда - нет");
}
if ( x == 4 )
{
    Console.WriteLine("четверг - нет");
}
if ( x == 5 )
{
    Console.WriteLine("пятница - нет");
}
if ( x == 6 )
{
    Console.WriteLine("суббота - да");
}
if ( x == 7 )
{
    Console.WriteLine("воскресенье - да");
}
if ( x > 7)
{
    Console.WriteLine("нет такого дня недели");
}
if ( x < 1 )
{
    Console.WriteLine("нет такого дня недели");
}
