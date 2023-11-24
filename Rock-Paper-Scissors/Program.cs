using System.Reflection.PortableExecutable;
using System.Threading.Channels;

Console.WriteLine("Welcome to the game Rock-Paper-Scissors");
Console.WriteLine("");
Console.Write("¿What is your name? ");
string name = Console.ReadLine()!;
string understeand = string.Empty;
bool validation = true;
int PlayerScore = 0;
int MachineScore = 0;
while (validation)
{
    Console.WriteLine($"Ok {name} those is the rules. ");
    Console.WriteLine($"The first that arrived to three is the winner");
    Console.WriteLine($"For you select one you must to write:");
    Console.WriteLine($"1-Rock");
    Console.WriteLine($"2-Paper");
    Console.WriteLine($"3-Scissors");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.Write("¿Are you understeand? ");
    understeand = Console.ReadLine()!;

    if(understeand == "si" || understeand == "Si")
    {
        validation = false;
    }

    if (understeand == "no" || understeand == "No")
    {
        Console.WriteLine("Repeat Again");
        Console.Clear();

    }


}
Console.Clear();
Console.WriteLine("Ok, Let's start");
Console.Clear();

Random random = new Random();

while (MachineScore < 3 || PlayerScore < 3)
{

    if (PlayerScore == 3)
    {
        Console.WriteLine("You win");
        break;
    }
    if(MachineScore == 3)
    {
        Console.WriteLine("Machine win");
        break;
    }


    var machineNum = random.Next(1, 3);
    Console.WriteLine("Insert your num");
    var playerNum = int.Parse(Console.ReadLine()!);
    Console.Clear();


    //for (int i = 1; i <= 3; i++)
    //{
    //    Console.WriteLine(i);
    //    Thread.Sleep(1000);
    //}

    Console.WriteLine();

    if (playerNum == 3 && machineNum == 2)
    {
        Console.WriteLine($"{name} winner, the machine choiced: Paper");
        ++PlayerScore;
    }
    if (playerNum == 2 && machineNum == 1)
    {
        Console.WriteLine($"{name} winner, the machine choiced: Rock");
        ++PlayerScore;
    }
    if (playerNum == 3 && machineNum == 1)
    {
        Console.WriteLine($"machineNum winner, you choiced: Scissors and the machine Rock");
        ++MachineScore;
    }

    if (machineNum == 3 && playerNum == 2)
    {
        Console.WriteLine($"machineNum winner, you choiced: Paper and the machine Scissors");
        ++MachineScore;
    }
    if (machineNum == 3 && playerNum == 1 )
    {
        Console.WriteLine($"{name} winner, the machine choiced: Scissors");
        ++PlayerScore;
    }
    if(machineNum == 2 && playerNum == 1)
    {
        Console.WriteLine($"machineNum winner, you choiced: Rock and the machine Paper");
        ++MachineScore;
    }

    if (playerNum == 3 && machineNum == 3)
    {
        Console.WriteLine($"tie");
    }
    if (playerNum == 2 && machineNum == 2)
    {
        Console.WriteLine($"tie");
    }
    if (playerNum == 1 && machineNum == 1)
    {
        Console.WriteLine($"tie");
    }


}




