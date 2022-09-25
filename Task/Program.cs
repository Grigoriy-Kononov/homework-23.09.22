
Console.Clear();
double Input()
{
              return Convert.ToInt32(Console.ReadLine());
}

/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

void Palindrom()
{
              Console.WriteLine("Введите пятизначное число: ");
              int abc = Convert.ToInt32(Math.Abs(Input()));
              if (abc > 99999 || abc < 10000) { Console.WriteLine("Недопустимое число"); }
              else
              {
                            string wer = Convert.ToString(abc);
                            if (wer[0] == wer[4] && wer[1] == wer[3])
                            {
                                          Console.WriteLine($"{wer} -> Да");
                            }
                            else 
                            { 
                                          Console.WriteLine($"{wer} -> Нет"); 
                            }
              }
}
/*
Palindrom();
*/


/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


void Distance()
{
                            Console.WriteLine("Введите координату Х1: ");
              double x1 = Input();
                            Console.WriteLine("Введите координату Y1: ");
              double y1 = Input();
                            Console.WriteLine("Введите координату Z1: ");
              double z1 = Input();
                            Console.WriteLine("Введите координату Х2: ");
              double x2 = Input();
                            Console.WriteLine("Введите координату Y2: ");
              double y2 = Input();
                            Console.WriteLine("Введите координату Z2: ");
              double z2 = Input();
              double temp = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
                            Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}), -> {Math.Round (temp, 2, MidpointRounding.AwayFromZero)}");
}
/*
Distance();
*/

/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


void CubeNumbers()
{
                            Console.WriteLine("Введите число: ");
              double x = Input();
              for (int i = 0; i < x; i++)
              {
                            double a = Convert.ToInt32 (Math.Pow(i+1, 3));
                            Console.Write($"{a}, ");
              }
}
/*
CubeNumbers();
*/

/*Напишите программу, которая на вход принимает радиус круга 
и находит его площадь округленную до целого числа, 
необходимо вывести максимальную цифру в полученном округлённом значении 
площади круга.

10 -> 4
20 -> 7
30 -> 8*/


void AreaCircle()
{
                            Console.WriteLine("Введите радиус: ");
              double x = Input();
              double temp = Math.PI*(Math.Pow(x, 2));
              double y = Math.Round (temp, 0, MidpointRounding.AwayFromZero);
              string z = Convert.ToString(y);
              char max = z[0];
              for (int i = 0; i < z.Length; i++)
              {
                            if (z[i] > max) max = z[i];
              }
              Console.Write($"{x} -> ");
              Console.WriteLine(max);
             
}
/*
AreaCircle();
*/

/*Напишите программу, которая на вход принимает букву, 
необходимо создать массив из 5 названий городов, 
и вывести на экран те (тот), где чаще всего встречается введённая буква.

Введённая буква: "о", 
массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"*/

void SearchBook()
{
              Console.WriteLine("Не смог");
}
/*
SearchBook();
*/
 while (true)
{
Console.WriteLine ("Введите номер задачи от 1 до 5, для выхода 6");
int Num = int.Parse(Console.ReadLine() ?? "0"); 
if (Num  == 1) Palindrom();
if (Num  == 2) Distance();
if (Num == 3) CubeNumbers();
if (Num  == 4) AreaCircle();
if (Num == 5) SearchBook();
if (Num < 1 && Num > 6) Console.WriteLine("Неверное значение. Введите только цифру от 1 до 6.");
if (Num == 6) break;
}