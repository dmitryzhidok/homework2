//заполнение массивы
Console.Write("write number of lines : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("write number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine($"i = {i}, j={j}");
        array[i,j]= Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();



}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();

}
Console.WriteLine();

//поиск положительных и отрицательных чисел
int positivNumbers = 0;
int negativeNumbers = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] > 0)
        {
            positivNumbers++;
        }

        else
        {
            negativeNumbers++;
        }
    }

}

Console.WriteLine("number of positive numbers: " + positivNumbers);
Console.WriteLine("number of negative numbers: " + negativeNumbers);


//сортировка массива
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int x = 0; x < array.GetLength(1); x++)
    {
        for (int y = 0; y < array.GetLength(1) - 1; y++)
        {
            int newasd = 0;

            if (array[i, y] > array[i, y + 1])
            {
                newasd = array[i, y];
                array[i, y + 1] = array[i, y];
                array[i, y + 1] = newasd;
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();

}

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int x = 0; x < array.GetLength(1); x++)
    {
        for (int y = 0; y < array.GetLength(1) - 1; y++)
        {
            int newcom = 0;

            if (array[i, y] < array[i, y + 1])
            {
                newcom = array[i, y];
                array[i, y + 1] = array[i, y];
                array[i, y + 1] = newcom;
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine();
//инверсия массива 

int[,] temp = new int[array.GetLength(0), array.GetLength(1)];
int assx = 0;
for (int i = array.GetLength(0) - 1; i >= 0; i--)
{
    var y = 0;
    for (int j = 0; j <array.GetLength(1); j++)
    {

        temp[assx, y] = array[i, j];
        y++;
    }
    assx++;

}
 


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
   {
      Console.Write(temp[i, j] + "\t");
   }  
    Console.WriteLine();

}