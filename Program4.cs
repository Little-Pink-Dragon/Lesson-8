Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] ThreeDimenSionalArray = new int[x, y, z];
CreateArray(ThreeDimenSionalArray);
WriteArray(ThreeDimenSionalArray);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] ThreeDimenSionalArray)
{
  for (int i = 0; i < ThreeDimenSionalArray.GetLength(0); i++)
  {
    for (int j = 0; j < ThreeDimenSionalArray.GetLength(1); j++)
    {
      
      for (int k = 0; k < ThreeDimenSionalArray.GetLength(2); k++)
      {
        Console.Write( $" {ThreeDimenSionalArray[i,j,k]} - ({i},{j},{k});");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] ThreeDimenSionalArray)
{
  int[] temp = new int[ThreeDimenSionalArray.GetLength(0) * ThreeDimenSionalArray.GetLength(1) 
  * ThreeDimenSionalArray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < ThreeDimenSionalArray.GetLength(0); x++)
  {
    for (int y = 0; y < ThreeDimenSionalArray.GetLength(1); y++)
    {
      for (int z = 0; z < ThreeDimenSionalArray.GetLength(2); z++)
      {
        ThreeDimenSionalArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}