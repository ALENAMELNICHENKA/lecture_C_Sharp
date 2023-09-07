// Сначала определим новый массив. Пусть это будет массив под именем array. Далее укажем,
// что в этом массиве будет по умолчанию 10 элементов. Запомним новую конструкцию new int
// [10], которая дословно означает «создай новый массив, где будет 10 элементов». По
// умолчанию. Кстати, он будет наполнен нулями. Чтобы заполнить массив случайными числами,
// воспользуемся методом, который опишем сами:



void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {  
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

//Итак, сначала мы определили массив из 10 элементов. Далее вызвали метод FillArray,
// который заполнил массив, а отдельный метод PrintArray нам его распечатал. В нашем случае
// это выглядит так:
// FillArray(array);
// PrintArray(array);

