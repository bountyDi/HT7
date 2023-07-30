int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(float[,]matrix)
{
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=random.Next(-1000,1000) / 10.0f;
        }
    }
}
void FillArrayInt(int[,]matrix, int minValue = -9, int maxValue=9)
{
    maxValue++;
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=random.Next(minValue,maxValue);
        }
    }
}
void PrintArrayInt(int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(float[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void Task47()
{
    int rows = 4;
    int colums = 3;
    float[,] matrix = new float[rows, colums];
    FillArray(matrix);
    PrintArray(matrix);
}

void Task50()
{
    int rows = 4;
    int colums = 3;
    int[,] matrix = new int[rows, colums];
    int i_find = Input("Введите индекс строки");
    int j_find = Input("Введите индекс столбца");
    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    if (i_find >= rows || j_find >= colums) Console.WriteLine("Элемента по данным индексам не существует");
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if (i_find==i && j_find==j)
            {
                Console.WriteLine(matrix[i,j]);
            }
        
        }
    }
}

void Task52()
{
    int rows = 4;
    int colums = 3;
    int[,] matrix = new int[rows, colums];
    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    double avrg = 0;
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
            avrg = sum/rows;
        }
        Console.WriteLine(avrg);
    }
}
Task52();