while (true)
{
    Console.WriteLine("Iveskite menesi: ");
    string month = Console.ReadLine();
    if (month == "sausis" || month == "vasaris" || month == "kovas")
    {
        Console.WriteLine("Saltas laikotarpis");
    }
    if (month == "birzelis" || month == "liepa" || month == "rugpjutis")
    {
        Console.WriteLine("Karstas laikotarpis");
    }
    if (month == "balandis" || month == "geguze" ||
        month == "rugsejis" || month == "spalis" ||
        month == "lapkritis" || month == "gruodis")

    {
        Console.WriteLine("Vidutinio laikotarpio menuo");
    }
    Console.ReadLine();
    Console.Clear();
}