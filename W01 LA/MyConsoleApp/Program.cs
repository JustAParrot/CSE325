// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

// Days until xmas
var now = DateTime.Now;
// Use next year if already past 25
var nextChristmasYear = (now.Month > 12) || (now.Month == 12 && now.Day > 25) ? now.Year + 1 : now.Year;
var nextChristmas = new DateTime(nextChristmasYear, 12, 25);
var daysUntilChristmas = (nextChristmas.Date - DateTime.Today).Days;

Console.WriteLine($"Days until next Christmas: {daysUntilChristmas}");
