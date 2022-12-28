Console.Clear();
Console.Write("Введите числа");
int[] array =Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for(int i=0; i<array.Length; i++)
{
    if(array[i]<0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество элементов меньше нуля: {count}");