using DiceRollGames.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult result = guessingGame.Play();
GuessingGame.PrintResult(result);

Console.ReadKey();





