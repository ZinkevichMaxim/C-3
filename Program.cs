// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int x1 = Prompt("Введите координату X: ");
// int y1 = Prompt("Введите координату Y: ");
// FindCoordinate(x1, y1);

// int x2 = Prompt("Введите координату X: ");
// int y2 = Prompt("Введите координату Y: ");
// FindCoordinate(x2, y2);

// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// void FindCoordinate(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("I четверть");
//     }
//     if (x < 0 && y > 0)
//     {
//         Console.WriteLine("II четверть");
//     }
//     if (x < 0 && y < 0)
//     {
//         Console.WriteLine("III четверть");
//     }
//     if (x > 0 && y < 0)
//     {
//         Console.WriteLine("IV четверть");
//     }
// }
// int sector = Prompt("Введите номер сектора");
// FindCoordinate(sector);

// int Prompt(string message)
// {
// Console.WriteLine(message);
// int nom = int.Parse(Console.ReadLine());
// return nom;
// }

// void FindCoordinate(int nom)
// {
// if (sector == 1)
// {
//     Console.WriteLine("х от 0 до + бесконечности; y от 0 до + бесконечности");
// }
// if (sector == 2)
// {
//     Console.WriteLine("х от 0 до минус бесконечности; y от 0 до + бесконечности");
// }
// if (sector == 3)
// {
//     Console.WriteLine("х от 0 до минус бесконечности; y от 0 до минус бесконечности");
// }
// if (sector == 4)
// {
//     Console.WriteLine("х от 0 до + бесконечности; y от 0 до минус бесконечности");
// }
// }

*************************************************************************************************************************

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("введите координаты первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты второй точки: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// double y2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// Console.WriteLine(result);
**************************************************************************************************************************
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4