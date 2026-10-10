//долги долговые долговят долговито..........
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите z:");
double z = double.Parse(Console.ReadLine());
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());

double s1 = (Math.Pow(x, 3) + Math.Pow(z, 5) - Math.Pow(a, 2)); //первым едйствием - возвести в степень(ну и то, что в скобках)
double s1_2 = (Math.Cos(s1)); //определяем косинус
double s2 = ((Math.Sin(Math.Pow(a, 2))) + s1_2)); // возведение в степень и полное действие в скобках 2
double s3 =  Math.Pow(x, 5); //возведение в степень 
double s3_2 = Math.Cos(b); //нахождение косинуса
double s3_3 = Math.Pow(s3_2, 7); //возведение в степень косинуса
double s3_4 = (s3_3 * s3); //умножение
double s4 = (s3_4 - s2); //нахождение числителя

double z1 =((Math.Pow(x, 7) - Math.Pow(a, 2))); //возведение степени и действие в скобках
double z2 = Math.Acos(z1); //нахождение арккос
double z2_2 = Math.Asin(Math.Pow(a,2)); //возведение в степень и нахождение арксин
double z3 = (z2_2 + z2); //нахождение знаменателя

double F = (s4 / z3); //нахождение значения функции
Console.WriteLine(F);