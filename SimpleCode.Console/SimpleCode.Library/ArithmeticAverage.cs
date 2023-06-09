namespace SimpleCode.Library;

public class ArithmeticAverage : Mathematics, IArithmeticAverage, INumberInput
{
    private readonly int _quantityNumber;
    private readonly int[] _number;

    public ArithmeticAverage(int quantity)
    {
        _quantityNumber = quantity;
        _number = new int[_quantityNumber];
    }

    void INumberInput.GetNumbers()
    {
        for (int i = 0; i < _quantityNumber; i++)
        {
            Console.WriteLine($"Введите число #{i + 1}:");
            _number[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void Average()
    {
        double sum = 0;
        for (int i = 0; i < _quantityNumber; i++)
        {
            sum += _number[i];
        }
        double average = sum / _quantityNumber;
        Console.WriteLine($"Среднее арифметическое {_quantityNumber} чисел: {average}");
    }
}