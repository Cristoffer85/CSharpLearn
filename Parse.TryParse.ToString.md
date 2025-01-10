// Konvertera int till string == .ToString
// Konvertera string till int == Parse, TryParse eller ConvertToInt 

string[] values = { "12,3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    if (decimal.TryParse(value, out decimal number)) // Parses numeric values
    {
        total += number; // Adds valid numeric values to the total
    }
    else
    {
        message += value; // Adds non-numeric strings to the message
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");