namespace human;
public class Human
{
    // Properties for Humans

    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligance { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }
    // Add a constructor to assing custom to all fields
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligance = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor  to assing custom values to all fields
    public Human(string name, int strength, int intelligance, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligance = intelligance;
        Dexterity = dexterity;
        Health = health;
    }

    // Build Attack method
    public int Attack(Human target)
    {
        int damage= Strength * 5; 
        target.Health -= damage;
        
        return target.Health;
    }
}