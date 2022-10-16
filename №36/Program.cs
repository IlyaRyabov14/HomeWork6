int [] ArrayA = new int[10];

void ArrayFull (int [] array)
{
int lenght = array.Length;
for(int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(10, 100);
    Console.Write($"{array[i]} ");
}
}

int result = 0;
ArrayFull(ArrayA);
for(int i = 0; i < ArrayA.Length; i++)
{
    if(i % 2 != 0)
    {
        result = result + ArrayA[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечётной позиции равна {result}");