// using Windows.ApplicationModel.VoiceCommands;

namespace TestScoresCalculator
{
    public partial class MainPage : ContentPage
    {
        int totalScore = 0; // accumulated score
        int testScoreCount = 0; // number of tests taken
        float averageScore = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddScoreClicked(object sender, EventArgs e)
        {
            // get the input and validate the input
            if (int.TryParse(txtScoreEntry.Text, out int testScore) && testScore >= 0 && testScore <= 100)
            {
                // conversion Worked
                ++testScoreCount; // increment the number of tests taken

                // math
                totalScore = totalScore + testScore;

                // int division is a problem
                // to solve the problem, we convert one of the variables (temporarily) to a float
                averageScore = (float)totalScore / testScoreCount; // calculate the average score

                // output the results to the labels
                lblTotalScore.Text = $"  {totalScore}";
                lblScoreCount.Text = $"  {testScoreCount}";
                lblAverage.Text = $"  {averageScore}"; 
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid score.", "OK");
            }

            txtScoreEntry.Text = string.Empty; // clear the input field
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            lblTotalScore.Text = string.Empty;
            lblScoreCount.Text = string.Empty;
            lblAverage.Text = string.Empty;
            txtScoreEntry.Text = string.Empty; // clear the input field
            totalScore = 0; // reset the total score
            testScoreCount = 0; // reset the number of tests taken
            averageScore = 0; // reset the average score
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }

   
    }
}
