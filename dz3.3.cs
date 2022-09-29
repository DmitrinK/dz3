// программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
int[] user3 = new int[userN]; // user3 - массив с числами
int count = 0;
int num = 1;
while (userN > count)
{
    user3[count]= num*num*num;
    num ++;
    count ++;
}
foreach(int answer in user3)
Console.Write(answer.ToString() + ",");