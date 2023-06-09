namespace SimpleCode.Library;

public class ProductNumber : Mathematics, IProductNumber, INumberInput
{
    private readonly int _quantityNumber;
    private readonly int[] _number;

    public ProductNumber(int quantity)
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

    public void Product()
    {
        int product = 1;
        for (int i = 0; i < _quantityNumber; i++)
        {
            product *= _number[i];
        }
        Console.WriteLine($"Произведение {_quantityNumber} чисел: {product}");
    }
}
