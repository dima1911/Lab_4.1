using System;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Ecosystem ecosystem = new Ecosystem();

        // Додаємо організми до екосистеми
        Animal lion = new Animal(100, 5, 2, "Lion");
        Animal deer = new Animal(50, 3, 1.5, "Deer");
        Plant tree = new Plant(30, 10, 5, "Oak");
        Microorganism bacteria = new Microorganism(10, 1, 0.01, "Bacteria");

        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(deer);
        ecosystem.AddOrganism(tree);
        ecosystem.AddOrganism(bacteria);

          ecosystem.SimulateEcosystem();

        Console.WriteLine("Simulation completed.");
    }
}

// Базовий клас "Живий організм"
public class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    public LivingOrganism(double energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

// Клас "Тварина"
public class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    public Animal(double energy, int age, double size, string species) : base(energy, age, size)
    {
        Species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Species} is reproducing.");
    }

    public void Hunt(LivingOrganism target)
    {
        Console.WriteLine($"{Species} is hunting.");
        // Ваша логіка полювання
    }
}

// Клас "Рослина"
public class Plant : LivingOrganism, IReproducible
{
    public string Type { get; set; }

    public Plant(double energy, int age, double size, string type) : base(energy, age, size)
    {
        Type = type;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Type} is reproducing.");
    }
}

// Клас "Мікроорганізм"
public class Microorganism : LivingOrganism, IReproducible
{
    public string Type { get; set; }

    public Microorganism(double energy, int age, double size, string type) : base(energy, age, size)
    {
        Type = type;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Type} is reproducing.");
    }
}

// Інтерфейс для розмноження
public interface IReproducible
{
    void Reproduce();
}

// Інтерфейс для полювання
public interface IPredator
{
    void Hunt(LivingOrganism target);
}

// Клас "Екосистема"
public class Ecosystem
{
    private List<LivingOrganism> organisms = new List<LivingOrganism>();

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateEcosystem()
    {
    }
}
