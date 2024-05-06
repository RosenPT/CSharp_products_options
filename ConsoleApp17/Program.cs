string[] products = { "coffee", "tea", "chocolate milk" };
string[] ingridients = { "sugar", "double sugar", "no sugar" };
string[] coffeeType = { "long", "short" };
string[] teaTypes = { "black tea", "herbal tea", "green tea" };
int position = 0;
string output = "";

foreach (var item in products)
{
    if (item == products[position])
    {
        Console.WriteLine("> " + item);
    }
    else
    {
        Console.WriteLine(item);
    }
}

while (true)
{
    ConsoleKeyInfo keyInput = Console.ReadKey();
    if (keyInput.Key == ConsoleKey.DownArrow)
    {
        Console.Clear();
        position++;
        if (position > products.Length - 1)
        {
            position = products.Length - 1;
        }
        foreach (var item in products)
        {
            if (item == products[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
    else if (keyInput.Key == ConsoleKey.UpArrow)
    {
        Console.Clear();
        position--;
        if (position < 0)
        {
            position = 0;
        }
        foreach (var item in products)
        {
            if (item == products[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
    else if (keyInput.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        Console.WriteLine("You chose " + products[position]);
        output = output + products[position];
        break;
    }
}

while (true)
{
    string product = products[position];
    if (product == "coffee")
    {
        Console.Clear();
        position = 0;
        foreach (var item in coffeeType)
        {
            if (item == coffeeType[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
        while (true)
        {
            ConsoleKeyInfo keyInput = Console.ReadKey();
            if (keyInput.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                position++;
                if (position > coffeeType.Length - 1)
                {
                    position = coffeeType.Length - 1;
                }
                foreach (var item in coffeeType)
                {
                    if (item == coffeeType[position])
                    {
                        Console.WriteLine("> " + item);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (keyInput.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                position--;
                if (position < 0)
                {
                    position = 0;
                }
                foreach (var item in coffeeType)
                {
                    if (item == coffeeType[position])
                    {
                        Console.WriteLine("> " + item);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (keyInput.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("You chose " + coffeeType[position]);
                output = output + " " + coffeeType[position];
                break;
            }
        }
        break;
    }
    else if (product == "tea")
    {
        Console.Clear();
        position = 0;
        foreach (var item in teaTypes)
        {
            if (item == teaTypes[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
        while (true)
        {
            ConsoleKeyInfo keyInput = Console.ReadKey();
            if (keyInput.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                position++;
                if (position > teaTypes.Length - 1)
                {
                    position = teaTypes.Length - 1;
                }
                foreach (var item in teaTypes)
                {
                    if (item == teaTypes[position])
                    {
                        Console.WriteLine("> " + item);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (keyInput.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                position--;
                if (position < 0)
                {
                    position = 0;
                }
                foreach (var item in teaTypes)
                {
                    if (item == teaTypes[position])
                    {
                        Console.WriteLine("> " + item);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (keyInput.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("You chose " + teaTypes[position]);
                output = output + " " + teaTypes[position];
                break;
            }
        }
        break;
    }
    else if (product == "chocolate milk")
    {
        Console.Clear();
        Console.WriteLine("You chose " + "chocolate milk");
        break;
    }
}

Console.Clear();
position = 0;
foreach (var item in ingridients)
{
    if (item == ingridients[position])
    {
        Console.WriteLine("> " + item);
    }
    else
    {
        Console.WriteLine(item);
    }
}

while (true)
{
    ConsoleKeyInfo keyInput = Console.ReadKey();
    if (keyInput.Key == ConsoleKey.DownArrow)
    {
        Console.Clear();
        position++;
        if (position > ingridients.Length - 1)
        {
            position = ingridients.Length - 1;
        }
        foreach (var item in ingridients)
        {
            if (item == ingridients[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
    else if (keyInput.Key == ConsoleKey.UpArrow)
    {
        Console.Clear();
        position--;
        if (position < 0)
        {
            position = 0;
        }
        foreach (var item in ingridients)
        {
            if (item == ingridients[position])
            {
                Console.WriteLine("> " + item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
    else if (keyInput.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        output = output + " " + ingridients[position];
        break;
    }
}

Console.WriteLine(output);
