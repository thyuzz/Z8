/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] GetMatrix(int line, int column){
    int [,] arrMat = new int[line, column];
    for (int i = 0; i < line; i++){
        for (int j = 0; j < column; j++){
            arrMat[i ,j] = Elements();
            Console.Write("\t" + arrMat[i ,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arrMat;
}

int Elements() {
    Random rnd = new Random();
    int el = rnd.Next(11);
    return el;
}

int [,] matrix = GetMatrix(4, 4);

int Sum(int i, int[,] arr){
    int sum = 0;
    int arrLenght = matrix.GetLength(1);
    for (int j = 0; j < arrLenght; j++){
        sum += arr[i,j];
    }
    return sum;
}

void MinSum(){
    int [] arrSum = new int[matrix.GetLength(1)];
    for (int i = 0; i < arrSum.Length; i++){
        arrSum[i] = Sum(i, matrix);
    }

    int min = arrSum[0];
    int index = 0;
    for (int i = 1; i < arrSum.Length; i++){
        if (min > arrSum[i]){
            min = arrSum[i];
            index = i;
        }
    }
    /* выводит именно номер строки, как мы начинаем считать (с единицы), а не как идёт реальный счёт массива (с нуля) */
    Console.Write("номер строки с наименьшей суммой элементов: " + (index+1));
}

MinSum();
