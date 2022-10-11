MyPigDice.PigDice pigDice = new();


// int score = pigDice.Play();

// System.Console.WriteLine(score);


// int amountofgames = 10;
// int highscore = pigDice.PlayTill(amountofgames);

// System.Console.WriteLine($"The highest score achieved in {amountofgames} is {highscore}");

//Failed rework
int dscore = 730;
// DateTime start = DateTime.Now;
// long breakingrecordsTest = pigDice.ReworkedRecordGame(dscore);
// var diff = DateTime.Now - start;

// System.Console.WriteLine($"it took the new function {breakingrecordsTest} and elapsed {diff} to meet the score of {dscore}");

DateTime starOg = DateTime.Now;
long breakingrecordsOg = pigDice.RecordGame(dscore);
var diffOg = DateTime.Now - starOg;


System.Console.WriteLine($"it took {breakingrecordsOg} and elapsed {diffOg} iterations to meet the score of {dscore}");

