using System.Security.Cryptography.X509Certificates;

var dog = new Dog();
dog.Name = "sharik";
dog.SetName(dog.Name);
dog.Eat();
abstract class Anymal
{
    public string Name { get; set; }
    public void SetName(string name)
    { this.Name = name; }
    public string GetName()
    {
        return Name;
    }
    public abstract void Eat();
    
}
class Dog : Anymal
{
    public override void Eat()
    {
        Console.WriteLine($"{Name} eat meat ");
    }
}
