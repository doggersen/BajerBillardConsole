// See https://aka.ms/new-console-template for more information
using BajerBillardConsole;

Console.WriteLine("Hello, World!");

Console.WriteLine("skriv navn på spiller 1");

Player player1 = new Player(Console.ReadLine());

Console.WriteLine("skriv navn på spiller 2");

Player player2 = new Player(Console.ReadLine());

Console.WriteLine($"Spiller 1: {player2.Name}, point: {player1.Points}");
Console.WriteLine($"Spiller 2: {player2.Name}, point: {player1.Points}");

Console.ReadKey();
