// -------------------------------------- The Enemy Class: --------------------------------------

// Enemy fields:
//          Name (i.e. Bandit, Boss, Guard)
//          Health
//          AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
// Constructor: 
//          When an Enemy is created, we must provide their Name upon creation
//          Health will start at a default value of 100
//          AttackList will initialize as an empty List
// Methods:
//          RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)

public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy (string name, int health)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack ()
    {
        Random number = new();
        int random = number.Next (0, AttackList.Count);
        Console.WriteLine($"{Name} performed attack {AttackList[random].Name}");
    }
}