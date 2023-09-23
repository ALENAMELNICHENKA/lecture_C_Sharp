//string[,] table = new string[2, 5];
// Индексы как для строк так и для столбцов меняются от 0 ....
// в нашем примере:
// table[0, 0]   table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0]   table[1, 1] table[1, 2] table[1, 3] table[1, 4]
// т.е. две строки и 5 столбцов
// По умолчанию, инициализация для строк происх. при пом. константы String.Empty

// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// Далее закомментируем предыд. пример и сделаем то же самое с числами, создадим новый массив
// можем проименовать переменные как привыкли, т.е. i, j

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Снова закомментируем предыд. пример и используем новую конструкцию в цикле
// для получения количества строк и столбцов: matrix.GetLength(0), в кач. агрумента передается 0
// где 0 = количество строк, а в matrix.GetLength(1), 1 = столбцы

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Снова закомментируем предыд. пример и напишем его же, но теперь с Методом
// который будет заполнять нашу матрицу FillArray.
//Так же немного изменим наш пример сразу добавив его в Метод Print
//В качестве аргумента передаем двумерную таблицу чисел [,] 
//и назовем аргумент немного иначе - matr

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// и здесь обращ-ся непосред.к эл-ту
                                             // i и j и через использование генератора
                                        //псевдослучайных чисел возьмём полуинтервал от 1 до 10
        }

    }
}
//Вызываем метод и в кач. аргумента передаем ту матрицу, котю была приведена выше

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

