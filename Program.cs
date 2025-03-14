
using System;
using System.Collections.Generic;

abstract class Product
{
    protected double BasePrice;

    public Product(double basePrice)
    {
        BasePrice = basePrice;
    }

    public abstract double Price { get; }

    public abstract string Name { get; }

    public virtual string GetInfo()
    {
        return $"Product: {Name}, Price: {Price}";
    }
}

class Carrot : Product
{
    public Carrot(double basePrice) : base(basePrice) { }

    public override double Price => BasePrice;

    public override string Name => "Carrot";
}

class Potato : Product
{
    private double Count;

    public Potato(double basePrice, double count) : base(basePrice)
    {
        Count = count;
    }

    public override double Price => BasePrice * Count;

    public override string Name => "Potato";

    public override string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }
}

class Cucumber : Product
{
    private double Count;

    public Cucumber(double basePrice, double count) : base(basePrice)
    {
        Count = count;
    }

    public override double Price => BasePrice * Count;

    public override string Name => "Cucumber";

    public override string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }
}

class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    public void PrintProductsInfo()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            Console.WriteLine(product.GetInfo());
            totalPrice += product.Price;
        }
        Console.WriteLine($"Total products price: {totalPrice}");
    }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProducts(products);
        shop.PrintProductsInfo();
    }
}
