Console.WriteLine("Введите трехзначное чило");
int N = Convert.ToInt32(Console.ReadLine());
if ( N < 1000 && N > 99 )
{
     Console.WriteLine("Последняя цифра "  +N%10);
}
else 
{
    Console.WriteLine("Нужно было ввести трехзначное число");
}