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
                bool isLastDigitANumber=int.TryParse(shipPosition.Substring(1), out int isNumber); 
                GridSpotModel ship=new();
                ship.SpotLetter=shipPosition.Substring(0,1);
                if(isLastDigitANumber)
                ship.SpotNumber=int.Parse(shipPosition.Substring(1));
                if("ABCDE".Contains(ship.SpotLetter)&& ship.SpotNumber>0 && ship.SpotNumber<6) //
                {
                    ships.Add(ship);
                    i++; 
                }
                else
                Console.WriteLine("Invalid Input.Enter A-E and 1-5");
            } 

           return ships;
        }
        public static GridSpotModel ShotPlacement(string text)
        {
            Console.WriteLine(text);
            GridSpotModel shot=new();
            string shotPosition=Console.ReadLine().ToUpper();
            shot.SpotLetter=shotPosition.Substring(0,1);
            shot.SpotNumber=int.Parse(shotPosition.Substring(1));
            return shot;

        }
    
}
}