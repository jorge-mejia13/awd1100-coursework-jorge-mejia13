Console.WriteLine("Name:");
string name = Console.ReadLine();

Console.WriteLine("Street Address");
string address = Console.ReadLine();

Console.WriteLine("City");
string city = Console.ReadLine();

Console.WriteLine("State");
string state = Console.ReadLine();

Console.WriteLine("Zip");
string zipcode = Console.ReadLine();

Console.WriteLine("Quantity");
double quantity = Convert.ToDouble(Console.ReadLine());

// price of a tshirt
const double TSHIRT_PRICE = 14.99;
// sales tax
const double SALES_TAX = 0.08;


// total price for tshirts (not including tax)
double totalPrice = quantity * TSHIRT_PRICE;

// sales tax
double salesTax = totalPrice * SALES_TAX;

// amount due (including sales tax)
double amountDue = (totalPrice * SALES_TAX) + totalPrice;


// output
Console.WriteLine("Name: {0}", name);
Console.WriteLine("Address: {0}", address);
Console.WriteLine("City: {0}", city);
Console.WriteLine("State: {0}", state);
Console.WriteLine("Zip Code: {0}", zipcode);
Console.WriteLine("Quantity: {0}", quantity);
Console.WriteLine("----------------------------");
Console.WriteLine("Total: {0:C}", totalPrice);
Console.WriteLine("Sales Tax: {0:C}", salesTax);
Console.WriteLine("Amount Due: {0:C}", amountDue);

