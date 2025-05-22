Console.WriteLine("Enter number of days car was rented for: ");
double numberOfDays = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter number of miles driven: ");
double numberOfMiles = Convert.ToDouble(Console.ReadLine());

const double CHARGE_PER_DAY = 100;
const double CHARGE_PER_MILE = 0.50;

double totalFee = (numberOfDays * CHARGE_PER_DAY) + (numberOfMiles * CHARGE_PER_MILE);

Console.WriteLine("Your total for your trip is: {0:C}", totalFee);
