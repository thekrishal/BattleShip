using BattleShipLibrary;
namespace BattleShipLibrary.Models
{
   public  class design
    {
        public static string CenterText(string text)
        {
           int spaces=(Console.WindowWidth-text.Length)/2;
           if(spaces<0)
           spaces=0;
           return new string(' ',spaces)+text; 
        }
        public static void PrintGrid(PlayerInfoModel player)
        {
            Console.Write("   ");
            int col;
            for(col=1;col<6;col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
            char row;
            for(row='A';row<='E' ;row++)
            {
                Console.Write(row + "  ");
                for (col= 1; col <= 5; col++)
                {
                    bool hasShip=player.ShipLocations.Any(x =>x.SpotLetter == row.ToString() &&x.SpotNumber == col);
                    if(hasShip)
                    {
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.Write("S ");
                    Console.ResetColor();
                    }
                    else{
                    Console.Write("~ ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press ENTER for another player's turn");
            }
        }
    }

