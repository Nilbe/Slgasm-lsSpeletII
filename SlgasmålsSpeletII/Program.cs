player p1 = new();
player p2 = new();

p1.weapon = new();
p2.weapon = new();

Console.WriteLine("What is your name warrior?");
p1.name = Console.ReadLine();

while(p1.HP > 0 || p2.HP > 0)
{
Console.WriteLine(p1.name + " HP: " + p1.HP);
Console.WriteLine("Opponent HP: " + p2.HP);
Console.ReadLine();


int dmg = p1.weapon.attack();
int dmg2 = p2.weapon.attack();

Console.WriteLine(p1.name + " has done " + dmg + " on opponent");
p1.HP -= dmg2;
Console.WriteLine("Opponent has done " + dmg2 + " on " + p1.name);
p2.HP -= dmg;


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
Console.ReadLine();