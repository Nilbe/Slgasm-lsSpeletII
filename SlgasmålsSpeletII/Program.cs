player p1 = new();
player p2 = new();

p1.weapon = new();
p2.weapon = new();

Console.WriteLine("What is your name warrior?");
p1.name = Console.ReadLine();



while(p1.HP > 0 && p2.HP > 0){
if(p1.HP <= 0 && p2.HP <= 0)
{
    Console.WriteLine("TIE!");
}
else if(p1.HP <= 0)
{
    Console.WriteLine("YOU DIED!");
    
}
else if(p2.HP <= 0)
{
    Console.WriteLine("YOU WIN!");
}
}

Console.ReadLine();