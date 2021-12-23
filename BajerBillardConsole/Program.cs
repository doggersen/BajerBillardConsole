
// See https://aka.ms/new-console-template for more information
using BajerBillardConsole;

Console.WriteLine("Hello, World!");

Console.WriteLine("skriv navn på spiller 1");

Player player1 = new Player(Console.ReadLine());

Console.WriteLine("skriv navn på spiller 2");

Player player2 = new Player(Console.ReadLine());

Console.WriteLine($"Spiller 1: {player2.Name}, point: {player1.Points}");
Console.WriteLine($"Spiller 2: {player2.Name}, point: {player1.Points}");

Console.WriteLine("dette er hele listen:");
//PlayerList playerList = new PlayerList();
List<Player> players = new List<Player>();
players.Add(player1);
players.Add(player2);
ShowList();

Console.WriteLine("now, add a player to the list directly!");
Console.WriteLine("name of player?");
//players.Add((Console.ReadLine());

void ShowList()
{
    foreach (var player in players)
    {
        Console.WriteLine(player.Name);
    }
}

{
    List<User> users = new List<User>();
    bool anotherUser = true;
    while (anotherUser)
    {
        Console.WriteLine("Please specify a name.");
        string userName = Console.ReadLine();
        User user = new User(userName);
        users.Add(user);

        Console.WriteLine("\nNames of added users:");
        foreach (User u in users)
        {
            Console.WriteLine(u.Name);
        }



        // Console.WriteLine("Do you want to add another user (type Y for yes)?");
        //anotherUser = (next == "Y");
        anotherUser = true;
    }

    Console.WriteLine("\nNames of added users:");
    foreach (User u in users)
    {
        Console.WriteLine(u.Name);
    }

    Console.ReadKey();
}






//playerList.ShowList();

Console.ReadKey();
