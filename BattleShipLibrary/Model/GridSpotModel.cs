namespace BattleShipLibrary;

public class GridSpotModel
{
 public string SpotLetter{get;set;}
 public int SpotNumber{get; set;}
 public string Status{get; set;} // 0=empty 1=ship_placed 2=hit 3=miss

}
