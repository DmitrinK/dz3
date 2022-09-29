/* программа, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
*/
Console.WriteLine("введите координаты первой точки х: ");
int userCoordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты первой точки y: ");
int userCoordY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты первой точки z: ");
int userCoordZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки х: ");
int userCoordX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки y: ");
int userCoordY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки z: ");
int userCoordZ2 = Convert.ToInt32(Console.ReadLine());
double resalt = Math.Sqrt (Math.Pow(userCoordX2 - userCoordX, 2) + Math.Pow(userCoordY2 - userCoordY, 2) + Math.Pow(userCoordZ2 - userCoordZ, 2));
Console.WriteLine (resalt);