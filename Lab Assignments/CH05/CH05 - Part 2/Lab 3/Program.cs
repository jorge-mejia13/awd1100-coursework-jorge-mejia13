// See https://aka.ms/new-console-template for more information

// each person total sales
double danielleSales = 0;
double francisSales = 0;
double edwardSales = 0;

//double amount; 
string initial;


while (true)
{
    // asks user for initial
    Console.WriteLine("Enter salesperson initial d, e, f, or z: ");

    // stores the initial in person variable
    initial = Console.ReadLine().Trim().ToLower();

    if (initial == "z")
    {
        break;
    }

    if (initial == "d" || initial == "e" || initial == "f")
    {
        if (initial == "d")
        {
            // asks user for sale amount
            Console.WriteLine("Enter the sales amount: ");
            // stores amount in variable
            string saleAmount = Console.ReadLine();
            double amount = double.Parse(saleAmount);

            danielleSales += amount;
        }

        if (initial == "e")
        {
            // asks user for sale amount
            Console.WriteLine("Enter the sales amount: ");
            // stores amount in variable
            string saleAmount = Console.ReadLine();
            double amount = double.Parse(saleAmount);

            edwardSales += amount;
        }

        if (initial == "f")
        { 
            // asks user for sale amount
            Console.WriteLine("Enter the sales amount: ");
            // stores amount in variable
            string saleAmount = Console.ReadLine();
            double amount = double.Parse(saleAmount);

            francisSales += amount;
        }

    } 
    else
    {
        Console.WriteLine("Please enter a correct initial");
    }


}

Console.WriteLine($"Danielle Sales: {danielleSales}");
Console.WriteLine($"Francis Sales: {francisSales}");
Console.WriteLine($"Edward Sales: {edwardSales}");

