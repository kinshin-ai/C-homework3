// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
int x1 = enterCoords("x1", "A1");
int y1 = enterCoords("y1", "A1");
int z1 = enterCoords("z1", "A1");
int x2 = enterCoords("x2", "A2");
int y2 = enterCoords("y2", "A2");
int z2 = enterCoords("z2", "A2");
int enterCoords(string coord, string pointName)
    {
    Console.Write($"введите координату {coord} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
    }
double distance(double x1, double x2, double y1, double y2, double z1, double z2)
    {
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    }
//double segmentLength = Math.Round(distance(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"расстояние между точками: {distance(x1, x2, y1, y2, z1, z2)}");