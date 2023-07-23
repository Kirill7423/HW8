// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] Create2DArray () 
{
    Console.WriteLine("Введите число строк");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int [,] ArrayFindMax (int [,] arrayStart)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
    {
        for (int j = 0; j < arrayStart.GetLength(1); j++)
        {
            for (int count = 0; count < (arrayStart.GetLength(1) - 1); count++)
            {
                if (arrayStart[i,count+1] > arrayStart[i,count])
                    {
                        int temp = arrayStart[i,count];
                        arrayStart[i,count] = arrayStart[i,count+1];
                        arrayStart[i,count+1] = temp;
                    }
            } 
        }
    }
    return arrayStart;
}
int [,] new2dArray = Create2DArray();
Print2DArray(new2dArray);
ArrayFindMax(new2dArray);
Print2DArray(new2dArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] Create2DArray () 
{
    Console.WriteLine("Введите число строк");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение");
    int userMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int [,] created2dArray = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int [] sumRows (int [,] Array)
{
    int [] sumRows = new int [Array.GetLength(0)];
        for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sumRows[i] += Array[i,j];
        }
    }
    return sumRows;
}

void PrintArraySum (int [] array_to_print)
{
    Console.Write("Суммы строк: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + " ");
Console.WriteLine();
}

void compRow (int [] array2)
{
    int min = array2[0];
    int minRow = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] < min)
            {
                minRow = i;
                min = array2[i];
            }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка");
}
int [,] new2dArray = Create2DArray();
if (new2dArray.GetLength(0) != new2dArray.GetLength(1))
{
Print2DArray(new2dArray);
PrintArraySum(sumRows(new2dArray)); 
compRow(sumRows(new2dArray));
}
else
{
    Console.WriteLine("Ошибка. Число строк не долно быть равным количеству столбцов");
}



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] Create2DArray () 
{
    Console.WriteLine("Введите число строк 1й матрицы");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов 1 матрицы");
    int userColls = Convert.ToInt32(Console.ReadLine());
    int [,] created2dArray = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            created2dArray[i,j] = new Random().Next(1,5);
        }
    }
    return created2dArray;
}

int [,] Create2DArraySec ()
{
    Console.WriteLine("Введите число строк 2 матрицы");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов 2й матрицы");
    int userColls = Convert.ToInt32(Console.ReadLine());
    int [,] created2dArraySec = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            created2dArraySec[i,j] = new Random().Next(1,5);
        }
    }
    return created2dArraySec;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int [,] Multi (int [,] array, int [,] array2)
{
    int [,] newArrMulti = new int [array.GetLength(0), array2.GetLength(1)];
    int elem = 0;
    for (int i = 0; i < newArrMulti.GetLength(0); i++)
    {
        for (int j = 0; j < newArrMulti.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(0); m++)
            {
                elem += array[i,m] * array2[m,j];
            }
            newArrMulti[i,j] = elem;
            elem = 0;
        }
    }
return newArrMulti;
}

int [,] new2dArray = Create2DArray();
int [,] new2dArraySec = Create2DArraySec();
Print2DArray(new2dArray);
Print2DArray(new2dArraySec);
if (new2dArray.GetLength(1) != new2dArraySec.GetLength(0))
    {
        Console.WriteLine("Умножение матриц невозможно");
    }
Print2DArray(Multi(new2dArray, new2dArraySec));



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] Create3DArray (int userRows, int userColls, int userLay) // 
{
    int [,,] created3dArray = new int [userRows, userColls, userLay];
    int count = new Random().Next(10, 50);
    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            for (int k =0; k < userLay; k++)
            {
            created3dArray[i,j,k] += count;
            count +=7;
            }
        }        
    }
    return created3dArray;
}

void Print3DArray(int [,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k =0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i,j,k]} ({i},{j},{k})  ");
            }
        Console.WriteLine(); 
        }
    }
    Console.WriteLine(); 
}

int [,,] new3dArray = Create3DArray(2,2,2);
Print3DArray(new3dArray);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] Create2DArray (int userRows, int userColls) 
{
    int [,] array2d = new int [userRows, userColls];
    int index = 1;
    int j = 0;
    int i = 0; 

    while (index <= (userRows * userColls))
    {
        for ( j = 0; j < array2d.GetLength(0); j++) // 1 строчка
            {
                array2d[i,j] = index;
                index++;
            }
                
        j = array2d.GetLength(1)-1; // крайний столбец вниз
        for (i = 1; i < array2d.GetLength(0); i++)
            {
                array2d[i,j] = index;
                index++;
            }

        i = array2d.GetLength(0)-1; //нижняя строка влево
        for (j = (array2d.GetLength(1) - 2); j > -1; j--)
            {
                array2d[i,j] = index;
                index++;
            }

        j = 0; // первый столбец вверх
        for (i = (array2d.GetLength(0) - 2); i > 0; i--)
            {
                array2d[i,j] = index;
                index++;
            }

        i = 1; // 2 строчка вправо
        for (j = 1; j < (array2d.GetLength(1) - 1); j++)
            {
                array2d[i,j] = index;
                index++;
            }

        i = array2d.GetLength(0) - 2; // 3 cнизу строка <
        for (j = (array2d.GetLength(1) - 2); j > 0; j--)
            {
                array2d[i,j] = index;
                index++;
            }
    }
    return array2d;
}

void Print2DArray(int[,] arrToShow)
{
    for (int i = 0; i < arrToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrToShow.GetLength(1); j++)
        {
            if (arrToShow[i, j] / 10 == 0)
                Console.Write($"0{arrToShow[i, j]} ");
            else
                Console.Write($"{arrToShow[i, j]} ");
        }
        Console.WriteLine();
    }
}

Print2DArray(Create2DArray(4, 4));

