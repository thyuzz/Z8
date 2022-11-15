/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using System;

int Elements() {
    Random rnd = new Random();
    int number = rnd.Next(10, 20);
    return number;
}

int [,,] GetThreeDimensionalArray(int line, int column, int dep){
    int[,,] array = new int[line, column, dep];
    for (int i = 0; i < line; i++){
        for (int j = 0; j < column; j++){
            for (int k = 0; k < dep; k++){
                array[i, j, k] = Elements();
            }
        }
    }
    
    return array;
}

int [,,] array = GetThreeDimensionalArray(2, 2, 2);
PrintArray(array);
Console.WriteLine("======");  

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{arr[i, j, k]}" + " (" + i + ", " + j + ", " + k + ") ");
                Console.WriteLine();            
            }
            
        }
        Console.WriteLine();        
    }        
} 
PrintArray(array);

/*
Я не знаю, как проверить на повторяемость элементы. */


