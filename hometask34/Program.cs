int[] Array(int size)
    {
      int [] array = new int [size];
      for(int i = 0 ;i < size;i++)
      { 
       Random rd = new Random();
       array[i] = rd.Next(99 , 1000);
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
void ChetnieNumbs(int [] array)
{   
    int chetnieNumbs = 0;
    for (int i = 0;i < array.Length;i++)
    {
        if (array[i]%2 == 0)
        {
         chetnieNumbs +=1;
        }
    }
     Console.WriteLine(chetnieNumbs);
}
Console.WriteLine("введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine()); 
int [] createdArray = Array(size);
ShowArray(createdArray);
ChetnieNumbs(createdArray);
