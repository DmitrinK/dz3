// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber/10000 < 1 || userNumber/10000 >= 10)
{
    Console.WriteLine("ошибка, число не пятизначное");
    return;
}
if (userNumber/10000 == userNumber%100%10 && userNumber/1000%10 == userNumber%100/10)
{
        Console.WriteLine("Да, число является палиндромом");
        return;
}
Console.WriteLine("Нет, число не является палиндромом");