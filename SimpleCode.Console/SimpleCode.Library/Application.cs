namespace SimpleCode.Library;

public class Application
{
    public void Run()
    {
        Console.WriteLine("Какое количество чисел вы желаете ввести для получения результата?");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите операцию: 'average' для среднего арифметического или 'product' для произведения чисел");
        string operation = Console.ReadLine();
        

        Mathematics? matematics = CreateMatematics(operation.ToLower(), quantity);
        if (matematics == null)
        {
            Console.WriteLine("Неверная операция.");
            return;
        }

        if (matematics is INumberInput _matematics)
        {
            _matematics.GetNumbers();
        }
        if (matematics is IArithmeticAverage arithmeticAverage)
        {
            arithmeticAverage.Average();
        }
        else if (matematics is IProductNumber productNumber)
        {
            productNumber.Product();
        }
    }

    private Mathematics? CreateMatematics(string operation, int quantity)
    {
        switch (operation)
        {
            case "average":
                return new ArithmeticAverage(quantity);
            case "product":
                return new ProductNumber(quantity);
            default:
                return null;
        }
    }
}