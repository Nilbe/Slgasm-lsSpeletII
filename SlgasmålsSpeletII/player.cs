using System;



public class player
{
    public string name;
    public int strength = 10;
    public int HP = 100;
    public  weapon weapon;

    public void attack(player target)
    {
        int damage = weapon.GetDamage();
        target.HP -= damage; 
        target.HP = Math.Max(0, target.HP);
        Console.WriteLine(name + " has done " + damage + " damage");
    }

}