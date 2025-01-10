Random random = new();
int heroHealth = 10;
int monsterHealth = 10;

bool PerformAttack(ref int defenderHealth, string attacker, string defender)
{
    int attackValue = random.Next(1, 11);
    defenderHealth -= attackValue;
    Console.WriteLine($"{attacker} attacks for {attackValue} damage. {defender} health: {Math.Max(defenderHealth, 0)}");

    if (defenderHealth <= 0)
    {
        Console.WriteLine($"{defender} is defeated! {attacker} wins!");
        return true;
    }
    return false;
}

do
{
    if (PerformAttack(ref monsterHealth, "Hero", "Monster")) break;
    if (PerformAttack(ref heroHealth, "Monster", "Hero")) break;
} while (heroHealth > 0 && monsterHealth > 0);