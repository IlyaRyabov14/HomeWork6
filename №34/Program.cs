int [] Array = new int[10];

void ArrayFull (int [] array)
{
int lenght = array.Length;
for(int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(10, 1000);
    Console.Write($"{array[i]} ");
    
}


}

ArrayFull(Array);
Console.WriteLine();
int count = Array.Length;
int Result = 0;
for(int i = 0; i < count; i++)
{
    if(Array[i] % 2 == 0)
    {
        Result++;
    }

}
Console.WriteLine($"В данном массиве {Result} четных чисел");