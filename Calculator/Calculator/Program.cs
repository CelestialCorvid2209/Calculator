class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my calculator!");
        Console.WriteLine("Please enter your equation in the format: number operator number (e.g., 2 + 2)");
        string equation = Console.ReadLine();
        string[] parts = equation.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string num1 = parts[0];
        string op = parts[1];
        string num2 = parts[2];
        double result = 0;

        switch (op)
        {
            case "+":
                result = double.Parse(num1) + double.Parse(num2);
                break;
            case "-":
                result = double.Parse(num1) - double.Parse(num2);
                break;
            case "*":
                result = double.Parse(num1) * double.Parse(num2);
                break;
            case "/":
                result = double.Parse(num1) / double.Parse(num2);
                break;
            default:
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                return;



        }

        Console.WriteLine($"The result is: {result}");
    }
}