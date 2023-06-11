// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void InArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void Sorted(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int row = j; row < array.GetLength(1); row++)
//             {
//                 if (array[i, j] < array[i, row])
//                 {
//                     int temp = array[i, row];
//                     array[i, row] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }

//         }
//     }
// }

// int[,] array = new int[5, 5];
// Console.WriteLine("Задан массив");
// InArray(array);
// PrintArray2D(array);
// Sorted(array);
// Console.WriteLine("Итог");
// PrintArray2D(array);


//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// void InArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] table = new int[5, 5];

// void SumSearchMin(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} \t");
//         Console.WriteLine();
//     }
// }
// InArray(table);
// PrintArray2D(table);
// Console.WriteLine();
// SumSearchMin(table);

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreArray(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next (min, max + 1);
//         }
//     }
//     return array;
// }
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("  ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],1} ");
//             else Console.Write($"{array[i, j],1} ");
//         }
//         Console.WriteLine("  ");
//     }
// }
// int[,] DiArray(int[,] array1, int[,] array2)
// {
//     var array3 = new int[array1.GetLength(0), array2.GetLength(1)];
//     if (array1.GetLength(1) == array2.GetLength(0))
//     {
//         for (int i = 0; i < array3.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3.GetLength(1); j++)
//             {
//                 array3[i, j] = 0;
//                 for (int n = 0; n < array1.GetLength(1); n++)
//                 {
//                     array3[i, j] += array1[i, n] * array2[n, j];
//                 }
//             }
//         }
//     }
//     return array3;
// }

//     int[,] array2D = CreArray(new Random().Next(2, 4), new Random().Next(2, 4), 0, 9);
//     int[,] array = CreArray(new Random().Next(2, 4), new Random().Next(2, 4), 0, 9);
//     PrintArray2D(array2D);
//     Console.WriteLine();
//     PrintArray2D(array);
//     Console.WriteLine();
//     PrintArray2D(DiArray(array2D, array));
//     Console.ReadLine();


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] CreArray (int row, int col, int dep, int min, int max) 
// {
//     int[,,] array = new int[row, col, dep];
//     Random rnd = new Random();   
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     array[i,j,k] = rnd.Next(min, max + 1);
//                 }
//         }
//     }
//     return array;
// } 

// void PrintArray3D(int[,,] matrix)
// {
//     for (int i = 0; i <  matrix.GetLength(0); i++)
//     {
//         Console.Write("  ");
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//             Console.Write($"{matrix[i, j, k], 1}  ");            
//             }
//         }
//         Console.WriteLine();        
//     }        
// }
// int[,,] array3D = CreArray(2, 2, 2, 10, 99);
// PrintArray3D(array3D);

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Не смогла, не понимаю как это сделать с помощью какой формулы спирально передвинуть 
