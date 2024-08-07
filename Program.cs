namespace SumDiagonal;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the square matrix: ");
        int size = int.Parse(Console.ReadLine());

        double[,] matrix = new double[size, size];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Enter element at position ({i}, {j}): ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Entered matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double sumDiagonal = 0;
        for (int i = 0; i < size; i++)
        {
            sumDiagonal += matrix[i, i];
        }

        Console.WriteLine($"The sum of diagonal elements is {sumDiagonal}");
    }
}

