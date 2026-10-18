using System;

int[] numbers = { 2, 4, 6 };

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Suma: {StatisticsHelper.CalculateSum(numbers)}");
Console.WriteLine($"Średnia: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Liczba elementów {numbers.Length}");