// See https://aka.ms/new-console-template for more information


// -------------------------------------- Testing --------------------------------------

// Create an instance of an Enemy in Program.cs (you can create any enemy you would like)
// Create 3 instances of Attacks in Program.cs (again, you can create any attacks you would like. Have fun with it!)
// Add the three Attacks to your Enemy instance's AttackList (hint: how do you add items to a List?)
// Call your Enemy instance's RandomAttack method to test that a random Attack can be called on 
//(a good developer will run this multiple times to ensure there are no bugs)




// Create an instance of an Enemy
Enemy enemy = new Enemy("Chun Li", 100);

// Create 3 instances of Attacks
Attack attack1 = new Attack("Yoso Kick", 20);
Attack attack2 = new Attack("Water Lotus Fist", 10);
Attack attack3 = new Attack("Spinning Bird Kick", 15);

// Add the three Attacks to your Enemy instance's AttackList
enemy.AttackList.Add(attack1);
enemy.AttackList.Add(attack2);
enemy.AttackList.Add(attack3);

// Call your Enemy instance's RandomAttack method to test random attack:
Console.WriteLine($"{enemy.Name} has {enemy.AttackList.Count} attacks:");
foreach (Attack attack in enemy.AttackList)
{
    enemy.RandomAttack();
}