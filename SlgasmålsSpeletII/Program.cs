player p1 = new();
player p2 = new();

p1.weapon = new();
p2.weapon = new();

Console.WriteLine("What is your name warrior?");
p1.name = Console.ReadLine();
p2.name = "Opponent";



while(p1.HP > 0 && p2.HP > 0)
{
    Console.WriteLine("Press enter to attack");
    Console.ReadLine();
    
    p1.attack(p2);
    p2.attack(p1);

    Console.WriteLine(p1.name + " HP: " + p1.HP);
    Console.WriteLine(p2.name + " HP: " + p2.HP);

    
}

if(p1.HP == 0 && p2.HP == 0)
{
    Console.WriteLine("TIE!");
}
else if(p1.HP == 0) 
{
    Console.WriteLine("YOU DIED!");   
}
else if(p2.HP == 0)
{
    Console.WriteLine("YOU WIN!");
}


Console.ReadLine();