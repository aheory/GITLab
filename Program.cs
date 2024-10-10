case ConsoleKey.D6:
case ConsoleKey.NumPad6:
    if (b == 0)
    {
        Console.WriteLine("Ошибка деление на ноль");
        break;
    }
    Console.WriteLine($"\nРезультат операции «/»: {a} * {b} = {a * b}");
    Console.ReadKey();
    break;