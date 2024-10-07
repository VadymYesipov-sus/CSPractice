using Practice14;

Mage mage = new Mage("Maximka", 100, 30, 5, 100.0);
Warrior warrior = new Warrior("Otenko", 150, 25, 15);

static void StartBattle(IFightable FirstFighter, IFightable SecondFighter)
{
       while(FirstFighter.Health > 0 & SecondFighter.Health > 0)
    {
        FirstFighter.Attack(FirstFighter, SecondFighter);
        SecondFighter.Attack(SecondFighter, FirstFighter);
    }

    if (FirstFighter.Health > SecondFighter.Health)
    {
        Console.WriteLine("{0} wins. GAME OVER", FirstFighter.FighterName);
    }
    else
    {
        Console.WriteLine("{0} wins. GAME OVER", SecondFighter.FighterName);
    }

}

StartBattle(mage, warrior);


