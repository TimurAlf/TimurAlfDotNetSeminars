// Задача 100: 10000<N<30000. нужно получить разбиение всех чисел от 2 до N на простые множители
// 2 = 2
// 3 = 3 
// 4 = 2 * 2
// 5 = 5
// 6 = 2 * 3
// разобраться в факторизации


System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i*i <= a; i+=2)
// {
//     if (a % i == 0)
//     {
//         if (i != a / i) Console.Write("{0} {1} ", i, a / i);
//         else Console.Write("{0} ", i, a / i);
//     }
// }

// int i = 2;
// while (i * i <= a)
// {
//     if (a % i == 0)
//     {
//         a = a / i;
//     }
//     else i += 1;
// }
// if (a > 1) System.Console.WriteLine(a);


// int i = 2;
// while (i * i <= a && a % i != 0) 
// {     
//     i += 1;
// }

// bool Simple(double a)// проверяем число a на простоту - а именно, делится ли a на i(число из диапозона {2.....√a})
// {
//     bool simple = true;
//     for (int i = 2; i <= Math.Sqrt(a); i++)
//     {
//         if (a % i == 0) simple = false;
//         else simple = true;
//     }
//     return simple;
// }

// System.Console.WriteLine(Simple(a));

// int b = 2;
// for (int i = 2; i <= a; i++)
// {
//     for (int c = 0; c <= a; c++)
//     {
//         if (Simple(a) == false)
//         {
//             System.Console.WriteLine($"{i} = {b} * {c} ");
//         }
//         else
//         {
//             System.Console.WriteLine($"{i} = {i} ");
//         }
//     }

// }

// int b = 2;

// for (int i = 2; i <= a; i++)
// {
//     if (i % 2 == 0)
//     {
//         if (i >= 4)
//         {
//             for (int c = 0; c < i; c = c + 2)
//             {
//                 do
//                 {

//                     c = i / 2;
//                     System.Console.WriteLine($"{i} = {b} * {c} ");
//                 } while (i % 2 >= 2);

//             }
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"{i} = {i} ");
//     }
// }
