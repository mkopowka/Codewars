﻿// See https://aka.ms/new-console-template for more information
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
FindMultiples findMultiples = new FindMultiples();  
SmallEnough smallEnough = new SmallEnough();
FindAverages findAverage = new FindAverages();
SortNumber sortNumber = new SortNumber();
SameCase sameCase = new SameCase();
SumOfCubes sumOfCubes = new SumOfCubes();
AddLengths al = new AddLengths();
FindLongests fl= new FindLongests();
SortGiftCodes stg= new SortGiftCodes();
xoxo.XO("xo");
validatePin.ValidatePinz("-1234");
checkIsTriange.IsTriangle(1, 2, 4);
checkIsSquare.IsSquare(5);
//minMax.Min(new[] { -32, 42, 2, 6, 7, 95 });
сenturyFromYear.СenturyFromYears(1902);
sum.summation(5);
alarm.SetAlarms(true, true);
rs.RentalCarCost(7);
s.Smashs(new string[] { "hello", "amazing", "world" });
cb.CountBy(2, 5);
removeSmall.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 });
findMultiples.FindMultiple(5,25);
smallEnough.SmallEnoughs(new int[] { 66, 101 }, 200);
findAverage.FindAverage(new double[] { 5, 5, 5, 5, 5 });
sortNumber.SortNumbers(new int[] { 42, 12, 1, 52 });
sameCase.SameCases('a','B');
sumOfCubes.SumCubes(4212);
al.AddLength("you will win");
//fl.FindLongest(new int[] { 534987, 2700943, 2305938, 2557115, 2752608, 1208274, 176809, 379875, 1032968, 942569, 1223586, 1137743 });
stg.SortGiftCode("abcdef");