Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

/*Regel 1: Koden ska bara visa ett meddelande.
Meddelandet som koden visar beror på de övriga fem reglerna. För regler 2–6 har de högre numrerade reglerna företräde framför de lägre numrerade reglerna.
*/

/*Regel 5: Om användarens prenumeration har upphört att gälla visar du meddelandet:
Your subscription has expired.*/
if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}

/*Regel 4: Om användarens prenumeration upphör att gälla om en dag visar du meddelandena:
Your subscription expires within a day!
Renew now and save 20%!*/
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

/*Regel 3: Om användarens prenumeration upphör att gälla om fem dagar eller mindre visar du meddelandena:
Your subscription expires in _ days.
Renew now and save 10%!*/
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

/*Regel 2: Om användarens prenumeration upphör att gälla om 10 dagar eller mindre visar du meddelandet:
Your subscription will expire soon. Renew now!*/
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

/*Regel 6: Om användarens prenumeration inte upphör att gälla om 10 dagar eller mindre visar du ingenting.*/
else
{
    // Do nothing
}