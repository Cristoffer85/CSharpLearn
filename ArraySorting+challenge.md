string[] pallets = [ "B14", "A11", "B12", "A13" ];

/* ########## SORT ##########
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/* ########## REVERSE ##########
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/* ########## CLEAR ##########
// Array.Clear(pallets, 0, 2); tar bort data från 2 arrayelement från objektet 0.
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/* ########## RESIZE ##########
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/* ########## MAKE A STRING AN ARRAY, ADD COMMAS BETWEEN AND OUTPUT IN COLUMN ##########
string value = "abc123";

// -- Make string array --
char[] valueArray = value.ToCharArray();

// -- Reverse --
Array.Reverse(valueArray);

// string result = new string(valueArray);
// -- Add comma between --
string result = string.Join(",", valueArray);
Console.WriteLine(result);

// -- Output in column --
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/* ########## CHALLENGE 1 ##########
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/

/* ########## CHALLENGE 2 ##########
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}
*/