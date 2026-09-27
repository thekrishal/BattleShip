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
        p2.UserName=GetData.PlayerName("PlayerB,Enter your name");
        p2.ShipLocations=GetData.ShipPlacement("Enter your 5 ship placements");
        Console.Clear();
    }
    public static void WelcomeMessage()
    {
        Console.WriteLine(design.CenterText("**************************************************************************"));
        Console.WriteLine(design.CenterText("Welcome to BattleShip"));
        Console.WriteLine(design.CenterText("**************************************************************************"));
    }
}

        

