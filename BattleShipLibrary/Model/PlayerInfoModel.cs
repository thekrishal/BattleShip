namespace BattleShipLibrary.Models
{
  public class PlayerInfoModel
    {
        public string UserName {get; set; }
        public List<GridSpotModel> ShipLocations {get; set;}=new();
        public List<GridSpotModel> ShotLocations{get; set;}=new();
    }
  
}

