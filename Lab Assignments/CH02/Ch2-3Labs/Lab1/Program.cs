const double KM_PER_MILE = 1.6;

Console.Write("Enter your distance in miles please: ");

double miles = Convert.ToDouble(Console.ReadLine());

double kilometers = miles * KM_PER_MILE;

Console.WriteLine("{0:0.0} miles is {1:0.0} kilometers", miles, kilometers);
