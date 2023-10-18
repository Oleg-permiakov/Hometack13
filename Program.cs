// Вывод третьей цифры любого числа или сообщает что третьей цифры нет
Console.WriteLine("Введите число");
string aname = Console.ReadLine();
int nam = Convert.ToInt32(aname);

while (nam >= 100 &&  nam < 1000)
{
    nam = nam % 10;
    Console.WriteLine(nam);
    
}
 
    if (nam < 100) Console.WriteLine("Третьей цифры нет");
    if (nam >= 1000 )
    {
        nam = nam / 10;
    }
   
