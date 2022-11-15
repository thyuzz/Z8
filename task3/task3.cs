/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    int el = rnd.Next(5);
    return el;
}

int [,] matrixA = GetMatrix(2, 2);
int [,] matrixB = GetMatrix(2, 2);

int m = matrixA.GetLength(0);
int n = matrixB.GetLength(1);

int [,] MatrixAxB(int line, int column){
    int [,] matrixC = new int[line, column];
    for (int i = 0; i < line; i++){
        for (int j = 0; j < column; j++){
            for (int k = 0; k < matrixA.GetLength(1); k++){
                matrixC[i,j] += matrixA[i,k]*matrixB[k,j];
            }
        }
    }
    return matrixC;
}

int [,] c = MatrixAxB(m, n);

void WriteMatrix(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write("\t" + arr[i ,j]);
        }
        Console.WriteLine();
    }  
} 

WriteMatrix(c);