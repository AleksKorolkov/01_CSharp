// Этапы создания массива:
// Пример : int[,] table = new int [3, 5];
// 1. Указание типа данных - int[,] 
// 2. Указание имени массива - table
// 3. выделение памяти под элементы new int [3, 5]. Первое число - количество строк. Второе - количество элементов в каждой из строк.


// Задача №1
// • Создать двумерный массив с размерами
// 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

// int[,] matrix = new int[3, 5];
// Random rnd = new Random();

// // Заполнение массива случайными числами от 1 до 10
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//     matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// Вывод массива в консоль

int [,] CreateMatrix (int rowCount, int columsCount);
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(); 

    }
}

int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);
