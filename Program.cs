using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Roburgert");

        double totalBurgerCost = 0.0;
        double totalToppingCost = 0.0;

        double BURGER_COST = 10.0;
        double TOPPING_COST = 0.50;
        double TIP_EXPENSE = 0.20;
        double SALES_TAX = 0.10;

        Console.WriteLine("How many burgers do you want?");
        int numberOfBurgers = int.Parse(Console.ReadLine());

        Console.WriteLine("How many toppings do you want?");
        int numberOfToppings = int.Parse(Console.ReadLine());

        totalBurgerCost = BURGER_COST * numberOfBurgers;
        totalToppingCost = TOPPING_COST * numberOfToppings;

        double totalOrderCost = (totalBurgerCost + totalToppingCost) * (1 + TIP_EXPENSE) + (numberOfBurgers * SALES_TAX);

        Console.WriteLine("Your total order cost is: $" + totalOrderCost);
    }
}

