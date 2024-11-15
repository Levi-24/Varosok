﻿using Varosok;

List<City> cities = new();
using StreamReader reader = new($"../../../src/varosok.csv");
_= reader.ReadLine();
while (!reader.EndOfStream) cities.Add(new City(reader.ReadLine()));

Console.WriteLine("Count:");
Console.WriteLine("\t" + cities.Count());

Console.WriteLine("1. Feladat:");
Console.WriteLine("\t" + cities.Where(c => c.CountryName == "Kína").Sum(c => c.Population));

Console.WriteLine("2. Feladat:");
Console.WriteLine("\t" + cities.Where(c => c.CountryName == "India").Average(c => c.Population));

Console.WriteLine("3. Feladat:");
Console.WriteLine("\t" + cities.OrderBy(c =>c.Population).Last());

Console.WriteLine("4. Feladat:");
cities.Where(c => c.Population > 20).OrderByDescending(c => c.Population).ToList().ForEach(c => { Console.WriteLine("\t" + c); });

Console.WriteLine("5. Feladat:");
Console.WriteLine("\t" + cities.GroupBy(c => c.CountryName).Where(g => g.Count() > 1).Count());

Console.WriteLine("6. Feladat:");
Console.WriteLine("\t" + cities.GroupBy(c => c.CityName[0]).OrderByDescending(g => g.Count()).First().Key);