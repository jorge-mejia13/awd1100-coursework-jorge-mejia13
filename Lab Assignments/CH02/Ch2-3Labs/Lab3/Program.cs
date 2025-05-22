const double PERCENT_RAISE = 0.04;

// person 1
Console.WriteLine("Enter the name of employee 1: ");
string name1 = Console.ReadLine();
Console.WriteLine("Enter the salary of employee 1: ");
double salary1 = Convert.ToDouble(Console.ReadLine());

// person 2
Console.WriteLine("Enter the name of employee 2: ");
string name2 = Console.ReadLine();
Console.WriteLine("Enter the salary of employee 2: ");
double salary2 = Convert.ToDouble(Console.ReadLine());


// person 3
Console.WriteLine("Enter the name of employee 3: ");
string name3 = Console.ReadLine();
Console.WriteLine("Enter the salary of employee 3: ");
double salary3 = Convert.ToDouble(Console.ReadLine());

// year 1
int year1 = 2018;

// year 2
int year2 = year1 + 1;
double salary1_2019 = salary1 + (salary1 * PERCENT_RAISE);
double salary2_2019 = salary2 + (salary2 * PERCENT_RAISE);
double salary3_2019 = salary3 + (salary3 * PERCENT_RAISE);

// year 3
int year3 = year1 + 2;
double salary1_2020 = salary1_2019 + (salary1_2019 * PERCENT_RAISE);
double salary2_2020 = salary2_2019 + (salary2_2019 * PERCENT_RAISE);
double salary3_2020 = salary3_2019 + (salary3_2019 * PERCENT_RAISE);


Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("{0,-10}| {1,-10} | {2,-10} | {3,-10}", "Year", name1, name2, name3);
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("{0,-10}| {1,-10:C} | {2,-10:C} | {3,-10:C}", year1, salary1, salary2, salary3);
Console.WriteLine("{0,-10}| {1,-10:C} | {2,-10:C} | {3,-10:C}", year2, salary1_2019, salary2_2019, salary3_2019);
Console.WriteLine("{0,-10}| {1,-10:C} | {2,-10:C} | {3,-10:C}", year3, salary1_2020, salary2_2020, salary3_2020);
