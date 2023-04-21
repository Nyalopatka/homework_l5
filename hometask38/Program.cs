double[] Array(int size,int minValue,int maxValue)
    {
      double [] array = new double [size];
      for(int i = 0 ;i < size;i++)
      { 
       
       double a = new Random().Next(minValue, maxValue+1 );
       double b = new Random().NextDouble();
       b = Math.Round(b,1);
       array[i] = a + b;
       
      }
      return array;
    }


void ShowArray(double [] array)
{
  for(int i = 0;i < array.Length;i++)
  {
Console.Write(array[i] + " ");
  }
  Console.Write(" -> ");
}


double Max(double [] array)
{
    double max = 0;
    for(int i = 0;i < array.Length;i++)
    {
      
      if (array[i] > max)
      {
        max= array[i];
      }
      
    }
    return max;
}


double Min(double [] array)
{
      double min = 100000000000000;
      for(int j = 0;j < array.Length;j++)
    {
      if (array[j] < min)
      {
        min = array[j];
        
      }
      
    }
    return min;
}

Console.WriteLine("введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("введите минимальное значение в массиве");
int minv = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение в массиве");
int maxv = Convert.ToInt32(Console.ReadLine());
double [] createdArray = Array(size,minv,maxv);
ShowArray(createdArray);
double maxRes = Max(createdArray);
double minRes = Min(createdArray);
double res = maxRes - minRes;
Console.WriteLine(res);