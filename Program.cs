// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




//  Console.WriteLine("Введите число");
//  int num1 = Convert.ToInt32(Console.ReadLine());

//   Console.WriteLine("Введите число");
//  int num2 = Convert.ToInt32(Console.ReadLine());

//  int step = num1;

//  for(int i =1; i < num2; i++)
//  {
//     step = step * num1;
//  }
//  Console.WriteLine(step);





//  Напишите программу, которая принимает на 
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


//  Console.WriteLine("Введите число");
//  int num = Convert.ToInt32(Console.ReadLine());

//  int sum = 0;

//  while(num>0)
//  {
// int count = num % 10;
// num = num / 10;
// sum = sum + count;
//  }
//  Console.WriteLine(sum);





// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int [] array = new int[8];
// GetArray();

// void GetArray()
// {
//    for (int i = 0; i < 8; i++)
//    {
//       array[i] = new Random().Next(1,99);
//       Console.Write(array[i]+" ");
//    }
// }