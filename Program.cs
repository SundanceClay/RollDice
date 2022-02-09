using RollDice;

string yn = "y";
do
{
    Console.Write("Enter number of sides for each dice and roll: ");
    int numbSidesDice = int.Parse(Console.ReadLine());

    int die1 = Dice.RollDice(numbSidesDice);
    int die2 = Dice.RollDice(numbSidesDice);
    int total = die1 + die2;
    Console.WriteLine($"Dice 1: {die1}");
    Console.WriteLine($"Dice 2: {die2}");
    Console.WriteLine($"Total for Roll: {total}");

    if (numbSidesDice == 6)
    {
        Console.WriteLine(Dice.CheckCombos(die1, die2));
        Console.WriteLine(Dice.CheckCombos(total));
    }
    Console.Write("Do you want to roll again? Enter y or n: ");
    yn = Console.ReadLine().ToLower();
}
while (yn == "y");
