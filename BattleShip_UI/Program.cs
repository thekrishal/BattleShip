/*To build a small, two-player console game that has its roots in the game Battleship from Mattel.There will be a 25-spot
grid (A1 - E5). Each player will place five pegs on the board to represent their five ships.Players will then take turns
firing on their opponent's ships. The first person to sink all five ships wins.*/
using BattleShipLibrary;
using BattleShipLibrary.Models;
namespace BattleShip_UI;

public class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        PlayerInfoModel p1=new PlayerInfoModel();
        PlayerInfoModel p2=new PlayerInfoModel();
        p1.UserName=GetData.PlayerName("PlayerA,Enter your name");
        p1.ShipLocations=GetData.ShipPlacement("Enter your 5 ship placements");
        design.PrintGrid(p1);
        Console.ReadLine();
        Console.Clear();
        p2.UserName=GetData.PlayerName("PlayerB,Enter your name");
        p2.ShipLocations=GetData.ShipPlacement("Enter your 5 ship placements");
        design.PrintGrid(p2);
        Console.ReadLine();
        Console.Clear();
        bool gameOver=false;
        while(!gameOver)
        {
            gameOver=GamePlay(p1,p2);
            if (!gameOver)
            gameOver=GamePlay(p2,p1);

        }
        Console.WriteLine("Press Enter to exit");
        Console.ReadLine();

    }
    public static void WelcomeMessage()
    {
        Console.ForegroundColor=ConsoleColor.Cyan;
        Console.WriteLine(design.CenterText("**************************************************************************"));
        Console.WriteLine(design.CenterText("Welcome to BattleShip"));
        Console.WriteLine(design.CenterText("**************************************************************************"));
        Console.ResetColor();
    }
    public static bool GamePlay(PlayerInfoModel attacker,PlayerInfoModel defender )
    {
        GridSpotModel shot=GetData.ShotPlacement($"{attacker.UserName},Enter your shot");
        bool alreadyShot=attacker.ShotLocations.Any(x=> x.SpotLetter==shot.SpotLetter && x.SpotNumber==shot.SpotNumber );
        if (alreadyShot)
        {
            Console.WriteLine("The location is already shot");
            return false;
        }
        else{
        attacker.ShotLocations.Add(shot);}
        bool hit=defender.ShipLocations.Any(x =>x.SpotLetter==shot.SpotLetter && x.SpotNumber==shot.SpotNumber);

        if(hit)
        {
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Hit");
        Console.ResetColor();
        GridSpotModel shipToRemove=defender.ShipLocations.FirstOrDefault(x =>x.SpotLetter==shot.SpotLetter&&x.SpotNumber==shot.SpotNumber);
        defender.ShipLocations.Remove(shipToRemove);
        }

        else
        {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Miss");
        Console.ResetColor();
        }

        if(defender.ShipLocations.Count==0)
            {
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
                Console.WriteLine(design.CenterText("**************************************************************************"));
                Console.WriteLine(design.CenterText($"{attacker.UserName.ToUpper()},is the winner"));
                Console.WriteLine(design.CenterText("All enemy ships are destroyed"));
                Console.WriteLine(design.CenterText("**************************************************************************"));
                Console.ResetColor();
                return true;
            }
            return false;
    }
}
    