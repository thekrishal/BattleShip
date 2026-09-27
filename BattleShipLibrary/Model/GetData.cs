namespace BattleShipLibrary.Models
{
    public class GetData
    {
        public static string PlayerName(string text)
        {
            Console.WriteLine(text);
            string name=Console.ReadLine();
            return name;
        }
        public static List<GridSpotModel>  ShipPlacement(string text)
        {
            Console.WriteLine(text);
            List<GridSpotModel> ships=new();
            int i;
            for(i=0;i<=4;)
            {
                string shipPosition=Console.ReadLine().ToUpper();
                GridSpotModel ship=new();
                ship.SpotLetter=shipPosition.Substring(0,1);
                ship.SpotNumber=int.Parse(shipPosition.Substring(1));
                if("ABCDE".Contains(ship.SpotLetter)&& ship.SpotNumber>0 && ship.SpotNumber<6) //
                {
                    ships.Add(ship);
                    i++; 
                }
                else
                Console.WriteLine("Invalid Input. Only enter A-E and 1-5");
            }     
           return ships;
        }
    
}
}