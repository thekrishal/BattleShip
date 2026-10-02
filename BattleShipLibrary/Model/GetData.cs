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
                if(shipPosition.Length<2)
                {
                    Console.WriteLine("Invalid Input.Enter A-E and 1-5");
                    continue;
                }
                bool isLastDigitANumber=int.TryParse(shipPosition.Substring(1), out int isNumber); 
                GridSpotModel ship=new();
                if(isLastDigitANumber)
                {
                ship.SpotLetter=shipPosition.Substring(0,1);
                ship.SpotNumber=int.Parse(shipPosition.Substring(1));
                }
                if("ABCDE".Contains(ship.SpotLetter)&& ship.SpotNumber>0 && ship.SpotNumber<6)
                {
                    bool alreadyExists=ships.Any(x =>x.SpotLetter == ship.SpotLetter && x.SpotNumber == ship.SpotNumber);
                    if (alreadyExists)
                    {
                        Console.WriteLine("You already places a ship there");
                    }
                    else
                    {
                    ships.Add(ship);
                    i++; 
                    }
                }
                else
                Console.WriteLine("Invalid Input.Enter A-E and 1-5");
            } 

           return ships;
        }
        public static GridSpotModel ShotPlacement(string text)
        {
            while (true)
            {
                Console.WriteLine(text);
                string shotPosition = Console.ReadLine().ToUpper();
                if (shotPosition.Length < 2)
                {
                    Console.WriteLine("Invalid Input. Enter A-E and 1-5");
                    continue;
                }
                bool isNumber = int.TryParse(shotPosition.Substring(1), out int spotNumber);
                if (isNumber &&"ABCDE".Contains(shotPosition.Substring(0, 1)) && spotNumber > 0 && spotNumber < 6)
                {
                    return new GridSpotModel
                    {
                        SpotLetter = shotPosition.Substring(0, 1),
                        SpotNumber = spotNumber
                    };
                }

                Console.WriteLine("Invalid Input. Enter A-E and 1-5");
        }
}
    
}
}