namespace BattleShipLibrary.Models
{
  public class PlayerInfoModel
    {
        public string UserName {get; set; }
        public List<GridSpotModel> ShipLocations {get; set;}
        public List<GridSpotModel> ShootLocations{get; set;}
    }
  
}

