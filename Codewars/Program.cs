// See https://aka.ms/new-console-template for more information
using Codewars;

Console.WriteLine("Hello, World!");

CheckIsTriange checkIsTriange= new CheckIsTriange();
CheckIsSquare checkIsSquare = new CheckIsSquare();
MinMax minMax = new MinMax();
СenturyFromYear сenturyFromYear = new СenturyFromYear();
ValidatePin validatePin = new ValidatePin();
Xoxo xoxo = new Xoxo();
Summation sum= new Summation();
SetAlarm alarm= new SetAlarm();
RentalCarCosts rs= new RentalCarCosts();
Smash s = new Smash();
CountsBy cb= new CountsBy();
RemoveSmall removeSmall= new RemoveSmall();
xoxo.XO("xo");
validatePin.ValidatePinz("-1234");
checkIsTriange.IsTriangle(1, 2, 4);
checkIsSquare.IsSquare(5);
minMax.Min(new[] { -32, 42, 2, 6, 7, 95 });
сenturyFromYear.СenturyFromYears(1902);
sum.summation(5);
alarm.SetAlarms(true, true);
rs.RentalCarCost(7);
s.Smashs(new string[] { "hello", "amazing", "world" });
cb.CountBy(2, 5);
removeSmall.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 });