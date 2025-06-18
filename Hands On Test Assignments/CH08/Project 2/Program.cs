Console.WriteLine("Please enter a price or type zero to finish");

int counter = 0;
double subTotal = 0;
double total = 0;
double tax = 0.08;
double taxAmount = 0;

while (true)
{

    string inputTxt = Console.ReadLine();

    if (double.TryParse(inputTxt, out double price))
    {
        if (price == 0)
        {
            break;
        }

        if (price < 0)
        {
            Console.WriteLine("Enter a valid price or zero to cancel");
            continue;
        }
        else
        {
            Console.WriteLine($"{counter++}: {price:C}");
            subTotal = subTotal + price;
            taxAmount = subTotal * tax;
            total = subTotal + taxAmount;
        }
    }
    else
    {
        Console.WriteLine("Enter a valid price or zero to cancel");
        continue;
    }
}

// --------------------------------------------------
Console.WriteLine($"Amount of items: {counter}");
Console.WriteLine($"Average Item Price: {subTotal / counter}");
Console.WriteLine($"Subtotal: {subTotal:C}");
Console.WriteLine($"Tax: {taxAmount:C}");
Console.WriteLine($"Total: {total:C}");

