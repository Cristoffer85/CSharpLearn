int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

//-------------------------------------------------------------------------------------

/*
string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
char specificLetter = 'B';

foreach (string item in orderIDs)
{
    if (item.StartsWith(specificLetter.ToString()))
    {
        Console.WriteLine($"Found item that starts with '{specificLetter}': {item}");
    }
}
*/