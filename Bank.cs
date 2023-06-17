namespace Heist
{

    public class Bank
    {

        public string BankName { get; set; }
        // Store a value for the bank's difficulty level. Set this value to 100.
        public int BankDifficultyLevel { get; set; }
        public int successfulRuns { get; set; }
        public int failedRuns { get; set; }


        public Bank()
        {
            BankName = "The Bank";
            BankDifficultyLevel = 0;
            successfulRuns = 0;
            failedRuns = 0;
        }

    }



}