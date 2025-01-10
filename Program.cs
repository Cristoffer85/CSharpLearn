for (int i = 0; i < 100; i++)
{
    // (i % 3 = equally divisible by 3, i % 5 = equally divisible by 5) put in switch statement
    string output = (i % 3, i % 5) switch
    {
        // if i % 3 = 0 and i % 5 = 0, output "FizzBuzz"
        (0, 0) => "FizzBuzz",
        // if i % 3 = 0, output "Fizz"
        (0, _) => "Fizz",
        // if i % 5 = 0, output "Buzz"
        (_, 0) => "Buzz",
        _ => i.ToString()
    };
    // print out the string output defined earlier
    Console.WriteLine(output);
}