namespace lw4.task2;

public class Task2
{
    public Task2()
    {
    }

    public void run()
    {
        SquareTest();
        Console.WriteLine("\n\n\n");
        CubeTest();
    }

    public void SquareTest()
    {
        TSquare<double> square1 = new TSquare<double>(5.0);
        TSquare<double> square2 = new TSquare<double>(3.0);

        Console.WriteLine("Square 1: Size = " + square1.Size);
        Console.WriteLine("Square 2: Size = " + square2.Size);

        Console.WriteLine("Square 1: Perimeter = " + square1.CulcPerimeter());
        Console.WriteLine("Square 1: Area = " + square1.CulcArea());
        Console.WriteLine("Square 2: Perimeter = " + square2.CulcPerimeter());
        Console.WriteLine("Square 2: Area = " + square2.CulcArea());

        if (square1.Equals(square2))
        {
            Console.WriteLine("Square 1 is equal to Square 2.");
        }
        else
        {
            Console.WriteLine("Square 1 is not equal to Square 2.");
        }

        TSquare<double> additionResult = square1 + square2;
        TSquare<double> subtractionResult = square1 - square2;
        TSquare<double> multiplicationResult = square1 * 2.0;

        Console.WriteLine("Addition Result: Size = " + additionResult.Size);
        Console.WriteLine("Subtraction Result: Size = " + subtractionResult.Size);
        Console.WriteLine("Multiplication Result: Size = " + multiplicationResult.Size);
    }

    public void CubeTest()
    {
        TCube<double> cube1 = new TCube<double>(3.0);
        TCube<double> cube2 = new TCube<double>(2.0);

        Console.WriteLine("Cube 1: Size = " + cube1.Size);
        Console.WriteLine("Cube 2: Size = " + cube2.Size);

        Console.WriteLine("Cube 1: Perimeter = " + cube1.CulcPerimeter());
        Console.WriteLine("Cube 1: Area = " + cube1.CulcArea());
        Console.WriteLine("Cube 1: Volume = " + cube1.CulcVolume());
        Console.WriteLine("Cube 2: Perimeter = " + cube2.CulcPerimeter());
        Console.WriteLine("Cube 2: Area = " + cube2.CulcArea());
        Console.WriteLine("Cube 2: Volume = " + cube2.CulcVolume());

        if (cube1.Equals(cube2))
        {
            Console.WriteLine("Cube 1 is equal to Cube 2.");
        }
        else
        {
            Console.WriteLine("Cube 1 is not equal to Cube 2.");
        }

        TCube<double> additionResultCube = cube1 + cube2;
        TCube<double> subtractionResultCube = cube1 - cube2;
        TCube<double> multiplicationResultCube = cube1 * 2;

        Console.WriteLine("Addition Result: Size = " + additionResultCube.Size);
        Console.WriteLine("Subtraction Result: Size = " + subtractionResultCube.Size);
        Console.WriteLine("Multiplication Result: Size = " + multiplicationResultCube.Size);
    }
}