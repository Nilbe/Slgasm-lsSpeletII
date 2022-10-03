using System;



public class weapon
{
    public string name = "sword";
    public int maxDamage = 10;
    public int minDamage = 4;
    public int weight;
    private Random generator = new();
    


    public int attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}
