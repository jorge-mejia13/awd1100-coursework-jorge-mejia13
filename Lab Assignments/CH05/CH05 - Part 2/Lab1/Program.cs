// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;


int score;
int total = 0;
int numOfTestScores = 0;
int lowestScore = 0;
int highestScore = 0;
int averageScore = 0;

while(true)
{
    Console.WriteLine("Please enter a score: ");

    string input = Console.ReadLine();

    score = int.Parse(input);
    

    if (score >= 0 && score <= 100)
    {
        total += score;
        numOfTestScores++;

        if (score < lowestScore)
        {
            lowestScore = score;
        }

        if (score > highestScore)
        {
            highestScore = score;
        }

        Console.WriteLine($"Please enter score: {score}");
    }

    if (score == 999)
    {
        break;
    }
}

//Console.WriteLine();

Console.WriteLine($"Number of scores: {numOfTestScores}");
Console.WriteLine($"Sum of scores: {total}");
Console.WriteLine($"Average score: {averageScore}");
Console.WriteLine($"Minimum score {lowestScore}");
Console.WriteLine($"Maximum score: {highestScore}");