Console.Write("Enter Test Score 1: ");
double score1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Test Score 2: ");
double score2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Test Score 3: ");
double score3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Test Score 4: ");
double score4 = Convert.ToDouble(Console.ReadLine());

double averageScore = (score1 + score2 + score3 + score4) / 4;

Console.WriteLine("The average of these four test scores is {0}", averageScore);