MyPigDice.PigDice pigDice = new();


// int score = pigDice.Play();

// System.Console.WriteLine(score);


// int amountofgames = 10;
// int highscore = pigDice.PlayTill(amountofgames);

// System.Console.WriteLine($"The highest score achieved in {amountofgames} is {highscore}");


int dscore = 725;
DateTime start = DateTime.Now;
long breakingrecords = pigDice.RecordGame(dscore);
var diff = DateTime.Now - start;

System.Console.WriteLine($"it took {breakingrecords} and elapsed {diff} to meet the score of {dscore}");

