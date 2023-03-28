while (true)
{
    var rnd = new Random();
    var rndInt = rnd.Next(1000000, 9999999);
    Console.WriteLine(rndInt);

    Console.WriteLine("\n\nPress any key for continue, key 'q' for exit");

    var anyKey = Console.ReadKey();

    if (anyKey.KeyChar == 'q')
    {
        Console.Clear();
        break;
    }
    Console.Clear();

    var input = Console.ReadLine();
    var success = int.TryParse(input, out var number);
    if (!success)
    {
        Console.Clear();
        Console.WriteLine("Invalid input, press any key for continue, key 'q' for exit");
        anyKey = Console.ReadKey();

        if (anyKey.KeyChar == 'q')
        {
            Console.Clear();
            break;
        }
    }
    else
    {
        if (number != rndInt)
        {
            Console.WriteLine("Invalid input, press any key for continue, key 'q' for exit");
            anyKey = Console.ReadKey();

            if (anyKey.KeyChar == 'q')
            {
                Console.Clear();
                break;
            }
        }
    }

    Console.Clear();
}