int [] ArrayB = new int[10];

void ArrayFull (int [] array)
{
int lenght = array.Length;
for(int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write($"{array[i]} ");
}
}
ArrayFull(ArrayB);
int Min = ArrayB[0];
int Max = 0;
int Lenght = ArrayB.Length;
for(int i = 0; i < Lenght; i++)
{
    if(ArrayB[i] > Max)
    {
        Max = ArrayB[i];
    }
    if(ArrayB[i] < Min)
    {
        Min = ArrayB[i];
    }
}
int result = Max - Min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минемальным элементом массива равна {result}");
