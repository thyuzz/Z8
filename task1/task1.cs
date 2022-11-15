/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


int [,] matrix = GetMatrix(3, 4);

void WriteMatrix(){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write("\t" + matrix[i ,j]);
        }
        Console.WriteLine();
    }  
} 

void BubbleSort(){
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int a = 0; a < matrix.GetLength(1); a++){
            for (int j = a + 1; j < matrix.GetLength(1); j++){
                if (matrix[i, a] < matrix[i, j]){
                    temp = matrix[i, a];
                    matrix[i, a] = matrix[i, j];
                    matrix[i, j] = temp;
                }                   
            }            
        }
    }
    WriteMatrix();
}

BubbleSort();


