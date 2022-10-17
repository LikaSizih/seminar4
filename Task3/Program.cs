int [] array = new int [8];
int i = 0;
while (i < array.Length)
{
array [i] = new Random().Next(0, 99);
Console.Write(array[i] + " ");
i++;
}
