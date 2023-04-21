int[] Array(int size,int minValue,int maxValue)
    {
      int [] array = new int [size];
      for(int i = 0 ;i < size;i++)
      { 
       Random rnd = new Random();
       array[i] = rnd.Next(minValue, maxValue);
      }
      return array;
    }
void ShowArray(int [] array)
{
  for(int i = 0;i < array.Length;i++)
  {
Console.Write(array[i] + " ");
  }
  Console.Write(" -> ");
}
void Summ(int [] array)
{   
    int summ = 0;
    for(int i = 1;i<array.Length;i+=2)
    {
        summ += array[i];
    }
    Console.WriteLine(summ);
}
Console.WriteLine("введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("введите минимальное значение в массиве");
int minv = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение в массиве");
int maxv = Convert.ToInt32(Console.ReadLine());
int [] createdArray = Array(size,minv,maxv);
ShowArray(createdArray);
Summ(createdArray);